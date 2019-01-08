namespace BloodPressureMeter
{
    partial class BloodPressureMeter
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbSystolicBloodPressure_1 = new System.Windows.Forms.TextBox();
            this.TbSystolicBloodPressure_2 = new System.Windows.Forms.TextBox();
            this.BtnSendOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbPressureRelief_1 = new System.Windows.Forms.TextBox();
            this.TbPressureRelief_2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "血壓分期判斷系統";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "收縮壓(毫米汞柱)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(18, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "舒壓(毫米汞柱)";
            // 
            // TbSystolicBloodPressure_1
            // 
            this.TbSystolicBloodPressure_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSystolicBloodPressure_1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TbSystolicBloodPressure_1.Location = new System.Drawing.Point(183, 140);
            this.TbSystolicBloodPressure_1.Name = "TbSystolicBloodPressure_1";
            this.TbSystolicBloodPressure_1.Size = new System.Drawing.Size(269, 30);
            this.TbSystolicBloodPressure_1.TabIndex = 3;
            // 
            // TbSystolicBloodPressure_2
            // 
            this.TbSystolicBloodPressure_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSystolicBloodPressure_2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TbSystolicBloodPressure_2.Location = new System.Drawing.Point(183, 263);
            this.TbSystolicBloodPressure_2.Name = "TbSystolicBloodPressure_2";
            this.TbSystolicBloodPressure_2.Size = new System.Drawing.Size(269, 30);
            this.TbSystolicBloodPressure_2.TabIndex = 4;
            // 
            // BtnSendOut
            // 
            this.BtnSendOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSendOut.BackColor = System.Drawing.Color.Brown;
            this.BtnSendOut.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.BtnSendOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSendOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSendOut.Location = new System.Drawing.Point(191, 357);
            this.BtnSendOut.Name = "BtnSendOut";
            this.BtnSendOut.Size = new System.Drawing.Size(192, 44);
            this.BtnSendOut.TabIndex = 5;
            this.BtnSendOut.Text = "SendOut";
            this.BtnSendOut.UseVisualStyleBackColor = false;
            this.BtnSendOut.Click += new System.EventHandler(this.BtnSendOut_Click_1);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(24, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "第一次測量";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(24, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "第二次測量";
            // 
            // TbPressureRelief_1
            // 
            this.TbPressureRelief_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPressureRelief_1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TbPressureRelief_1.Location = new System.Drawing.Point(183, 179);
            this.TbPressureRelief_1.Name = "TbPressureRelief_1";
            this.TbPressureRelief_1.Size = new System.Drawing.Size(269, 30);
            this.TbPressureRelief_1.TabIndex = 8;
            // 
            // TbPressureRelief_2
            // 
            this.TbPressureRelief_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPressureRelief_2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TbPressureRelief_2.Location = new System.Drawing.Point(183, 309);
            this.TbPressureRelief_2.Name = "TbPressureRelief_2";
            this.TbPressureRelief_2.Size = new System.Drawing.Size(269, 30);
            this.TbPressureRelief_2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(14, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "收縮壓(毫米汞柱)";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(24, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "舒壓(毫米汞柱)";
            // 
            // BloodPressureMeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(464, 430);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbPressureRelief_2);
            this.Controls.Add(this.TbPressureRelief_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSendOut);
            this.Controls.Add(this.TbSystolicBloodPressure_2);
            this.Controls.Add(this.TbSystolicBloodPressure_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BloodPressureMeter";
            this.Text = "BloodPressureMeter";
            this.Load += new System.EventHandler(this.BloodPressureMeter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbSystolicBloodPressure_1;
        private System.Windows.Forms.TextBox TbSystolicBloodPressure_2;
        private System.Windows.Forms.Button BtnSendOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbPressureRelief_1;
        private System.Windows.Forms.TextBox TbPressureRelief_2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

