using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf14_winforms_thread
{
    public partial class FrmMain : Form
    {
        int number = 0;
        int percent = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Worker.WorkerSupportsCancellation = true;
            Worker.WorkerReportsProgress = true;
        }

        // 백그라운드로 일 진행 // Thread.Start()
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker; // 인자값으로 Background 생성 , shallow copy , addr same

            e.Result = Fibonacci((int)e.Argument, worker, e); // fibonacci method


        }

        private long Fibonacci(int arg, BackgroundWorker worker, DoWorkEventArgs e)
        {
            // Parameter : arg's range is 0 ~ 91/ if bigger than 91 , long overflow
            if (arg < 0 || arg > 91)
            {
                throw new Exception("ERROR INPUT 0~91");
            }

            long result = 0;

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
            }
            else
            {
                if (arg < 2) result = 1;

                else
                {
                    // arg만 계산에 필요한 매개변수, worker, e 중간에 취소할 떄 필요한 Background 복사본
                    result = Fibonacci(arg - 1, worker, e) + Fibonacci(arg - 2, worker, e);
                }

                // 진행사항을 프로그래스바에 표시
                int percentComplete = (int)(arg / number * 100);
                if (percentComplete > percent)
                {
                    percent = percentComplete;
                    worker.ReportProgress(percentComplete); // ProgressChanged 이벤트발생
                }
            }
            return result;
        }

        // 백그라운드 스레드 테스크 종료한 뒤 처리
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                LblResult.Text = "취소됨";
            }
            else
            {
                LblResult.Text = e.Result.ToString();
            }
            TxtNumber.Text = 0.ToString();
            BtnStart.Enabled = true;
            BtnCancel.Enabled = false;


        }

        // 백그라운드 스레드 진행중 프로그레스 표시
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PgbCalculate.Value = e.ProgressPercentage; // 진행사항 표시
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Button button = sender as Button;

            BtnStart.Enabled = false; // 시작버튼은 종료시 까지 누르지못함
            BtnCancel.Enabled = true;

            number = int.Parse(TxtNumber.Text);

            percent = 0;
            PgbCalculate.Value = percent;
            Worker.RunWorkerAsync(number); // 비동기로 진행

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Worker.CancelAsync();
            BtnCancel.Enabled = false;
            BtnStart.Enabled = true;
        }

    }
}