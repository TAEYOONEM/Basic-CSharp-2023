using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace wf13_bookRentalShop
{
    public partial class FrmLogin : Form
    {
        private bool IsLogined = false; // 로그인 성공했는지 물어보는 변수
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            IsLogined = LoginProcess();
            if (IsLogined)
            {
                this.Close();
            }
            else
            {
                return;
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0); // 가장 완벽하게 프로그램 종료
        }

        // 이게 없으면 X버튼이나 Alt + F4로 했을때 메인폼이 나타남
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsLogined != true) Environment.Exit(0);
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 엔터키를 누르면
            {
                BtnLogin_Click(sender, e); // 버튼 클릭 이벤트핸들러 호출
            }
        }

        // DB userTBL에서 정보확인 로그인 처리
        private bool LoginProcess()
        {
            // validaion check 입력검증
            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("유저 아이디를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("패스워드를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string strUserId = "";
            string strPassword = "";
            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=bookrentalshop;Uid=root;Pwd=12345";
                // DB 처리

                //MySqlConnection conn = new MySqlConnection(connectionString);
                //conn.Open();
                //conn.Close();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    #region << DB 쿼리를 위한 구성 >>
                    string selQuery = @"SELECT userId
                                             , password
                                          FROM usertbl
                                         Where userID = @userID
                                           And password = @password";

                    MySqlCommand selCmd = new MySqlCommand(selQuery, conn);
                    // @userID, @password 파라미터 할당
                    MySqlParameter prmUserID = new MySqlParameter("@userId", TxtUserId.Text);
                    MySqlParameter prmPassword = new MySqlParameter("@password", TxtPassword.Text);
                    selCmd.Parameters.Add(prmUserID);
                    selCmd.Parameters.Add(prmPassword);
                    #endregion

                    // conn.Close();
                    MySqlDataReader reader = selCmd.ExecuteReader(); // 실행한 다음에 userId, password
                    if (reader.Read())
                    {
                        strUserId = reader["userId"] != null ? reader["userId"].ToString() : "-";
                        strPassword = reader["password"] != null ? reader["password"].ToString() : "-";
                    }
                    else
                    {
                        MessageBox.Show("로그인정보가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                MessageBox.Show($"{strUserId} / {strPassword}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적인 오류 {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
