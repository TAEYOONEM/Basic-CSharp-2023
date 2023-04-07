namespace wf05_login
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.TbPw = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "패스워드";
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(125, 75);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(100, 21);
            this.TbId.TabIndex = 1;
            // 
            // TbPw
            // 
            this.TbPw.Location = new System.Drawing.Point(125, 107);
            this.TbPw.Name = "TbPw";
            this.TbPw.Size = new System.Drawing.Size(100, 21);
            this.TbPw.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(233, 147);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblSuccess
            // 
            this.LblSuccess.AutoSize = true;
            this.LblSuccess.Location = new System.Drawing.Point(233, 186);
            this.LblSuccess.Name = "LblSuccess";
            this.LblSuccess.Size = new System.Drawing.Size(0, 12);
            this.LblSuccess.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 258);
            this.Controls.Add(this.LblSuccess);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TbPw);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.TextBox TbPw;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblSuccess;
    }
}

