using System.Windows.Forms;

namespace Singin
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.mPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSingin = new System.Windows.Forms.Button();
            this.mPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold);
            this.lblLoginUserName.ForeColor = System.Drawing.Color.Blue;
            this.lblLoginUserName.Location = new System.Drawing.Point(105, 252);
            this.lblLoginUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(553, 108);
            this.lblLoginUserName.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.Font = new System.Drawing.Font("PMingLiU", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.Location = new System.Drawing.Point(14, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 58);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // mPanel
            // 
            this.mPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanel.Controls.Add(this.label1);
            this.mPanel.Controls.Add(this.tbUsername);
            this.mPanel.Controls.Add(this.tbPassword);
            this.mPanel.Controls.Add(this.btnSingin);
            this.mPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mPanel.Location = new System.Drawing.Point(-1, 36);
            this.mPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(749, 756);
            this.mPanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Image = global::Singin.Properties.Resources.sticker;
            this.label1.Location = new System.Drawing.Point(19, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 320);
            this.label1.TabIndex = 12;
            this.label1.UseMnemonic = false;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.BackColor = System.Drawing.Color.White;
            this.tbUsername.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbUsername.ForeColor = System.Drawing.Color.Silver;
            this.tbUsername.Location = new System.Drawing.Point(22, 407);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbUsername.Size = new System.Drawing.Size(697, 58);
            this.tbUsername.TabIndex = 14;
            this.tbUsername.Text = "Username";
            this.tbUsername.Enter += new System.EventHandler(this.Tb_Username_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.Tb_Username_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(22, 500);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbPassword.Size = new System.Drawing.Size(697, 58);
            this.tbPassword.TabIndex = 15;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.Tb_password_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.Tb_password_Leave);
            // 
            // btnSingin
            // 
            this.btnSingin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSingin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSingin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSingin.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSingin.ForeColor = System.Drawing.Color.White;
            this.btnSingin.Location = new System.Drawing.Point(462, 594);
            this.btnSingin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSingin.Name = "btnSingin";
            this.btnSingin.Size = new System.Drawing.Size(254, 99);
            this.btnSingin.TabIndex = 13;
            this.btnSingin.Text = "Sign in";
            this.btnSingin.UseVisualStyleBackColor = false;
            this.btnSingin.Click += new System.EventHandler(this.Btn_SingIn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(746, 830);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.lblLoginUserName);
            this.Controls.Add(this.btnBack);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LogIn";
            this.Text = "Log in";
            this.HandleCreated += new System.EventHandler(this.Control_HandleCreated);
            this.BindingContextChanged += new System.EventHandler(this.Control_BindingContextChanged);
            this.Load += new System.EventHandler(Form_Load);
            this.VisibleChanged += new System.EventHandler(this.Control_VisibleChanged);
            this.Activated += new System.EventHandler(this.Form_Activated);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblLoginUserName;

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel mPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnSingin;
    }
}

