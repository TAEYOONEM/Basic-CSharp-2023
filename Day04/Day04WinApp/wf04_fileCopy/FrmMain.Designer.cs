﻿namespace wf04_fileCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFindSource = new System.Windows.Forms.Button();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFindTarget = new System.Windows.Forms.Button();
            this.TxtTarget = new System.Windows.Forms.TextBox();
            this.BtnAsyncCopy = new System.Windows.Forms.Button();
            this.BtnSyncCopy = new System.Windows.Forms.Button();
            this.PgbCopy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source :";
            // 
            // BtnFindSource
            // 
            this.BtnFindSource.Location = new System.Drawing.Point(403, 17);
            this.BtnFindSource.Name = "BtnFindSource";
            this.BtnFindSource.Size = new System.Drawing.Size(39, 23);
            this.BtnFindSource.TabIndex = 2;
            this.BtnFindSource.Text = "...";
            this.BtnFindSource.UseVisualStyleBackColor = true;
            this.BtnFindSource.Click += new System.EventHandler(this.BtnFindSource_Click);
            // 
            // TxtSource
            // 
            this.TxtSource.Location = new System.Drawing.Point(63, 19);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(334, 21);
            this.TxtSource.TabIndex = 1;
            this.TxtSource.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Target :";
            // 
            // BtnFindTarget
            // 
            this.BtnFindTarget.Location = new System.Drawing.Point(403, 44);
            this.BtnFindTarget.Name = "BtnFindTarget";
            this.BtnFindTarget.Size = new System.Drawing.Size(39, 23);
            this.BtnFindTarget.TabIndex = 4;
            this.BtnFindTarget.Text = "...";
            this.BtnFindTarget.UseVisualStyleBackColor = true;
            this.BtnFindTarget.Click += new System.EventHandler(this.BtnFindTarget_Click);
            // 
            // TxtTarget
            // 
            this.TxtTarget.Location = new System.Drawing.Point(63, 46);
            this.TxtTarget.Name = "TxtTarget";
            this.TxtTarget.Size = new System.Drawing.Size(334, 21);
            this.TxtTarget.TabIndex = 3;
            this.TxtTarget.TabStop = false;
            // 
            // BtnAsyncCopy
            // 
            this.BtnAsyncCopy.Location = new System.Drawing.Point(110, 91);
            this.BtnAsyncCopy.Name = "BtnAsyncCopy";
            this.BtnAsyncCopy.Size = new System.Drawing.Size(93, 23);
            this.BtnAsyncCopy.TabIndex = 5;
            this.BtnAsyncCopy.Text = "Async Copy";
            this.BtnAsyncCopy.UseVisualStyleBackColor = true;
            this.BtnAsyncCopy.Click += new System.EventHandler(this.BtnAsyncCopy_Click);
            // 
            // BtnSyncCopy
            // 
            this.BtnSyncCopy.Location = new System.Drawing.Point(267, 91);
            this.BtnSyncCopy.Name = "BtnSyncCopy";
            this.BtnSyncCopy.Size = new System.Drawing.Size(88, 23);
            this.BtnSyncCopy.TabIndex = 6;
            this.BtnSyncCopy.Text = "Sync Copy";
            this.BtnSyncCopy.UseVisualStyleBackColor = true;
            this.BtnSyncCopy.Click += new System.EventHandler(this.BtnSyncCopy_Click);
            // 
            // PgbCopy
            // 
            this.PgbCopy.Location = new System.Drawing.Point(10, 140);
            this.PgbCopy.Name = "PgbCopy";
            this.PgbCopy.Size = new System.Drawing.Size(449, 23);
            this.PgbCopy.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 187);
            this.Controls.Add(this.PgbCopy);
            this.Controls.Add(this.BtnSyncCopy);
            this.Controls.Add(this.BtnAsyncCopy);
            this.Controls.Add(this.TxtTarget);
            this.Controls.Add(this.BtnFindTarget);
            this.Controls.Add(this.TxtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnFindSource);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async File Copy";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFindSource;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFindTarget;
        private System.Windows.Forms.TextBox TxtTarget;
        private System.Windows.Forms.Button BtnAsyncCopy;
        private System.Windows.Forms.Button BtnSyncCopy;
        private System.Windows.Forms.ProgressBar PgbCopy;
    }
}

