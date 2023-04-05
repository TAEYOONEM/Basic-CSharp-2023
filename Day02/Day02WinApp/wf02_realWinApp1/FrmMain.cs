using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf02_realWinApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 버튼 OK클릭 이벤트에 대한 처리 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼 클릭!!!", "클릭", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnOk_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("asd");
        }
    }
}
