namespace SortArray
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBeforeSorting = new System.Windows.Forms.Label();
            this.lblAfterSorting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubjectSorting = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnRankingOfGrades = new System.Windows.Forms.Button();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.tbNameInput = new System.Windows.Forms.TextBox();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblSumOfResults = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBeforeSorting
            // 
            this.lblBeforeSorting.BackColor = System.Drawing.Color.ForestGreen;
            this.lblBeforeSorting.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBeforeSorting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBeforeSorting.Location = new System.Drawing.Point(10, 95);
            this.lblBeforeSorting.Name = "lblBeforeSorting";
            this.lblBeforeSorting.Size = new System.Drawing.Size(224, 323);
            this.lblBeforeSorting.TabIndex = 0;
            this.lblBeforeSorting.Text = "排序前";
            // 
            // lblAfterSorting
            // 
            this.lblAfterSorting.BackColor = System.Drawing.Color.ForestGreen;
            this.lblAfterSorting.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAfterSorting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAfterSorting.Location = new System.Drawing.Point(240, 95);
            this.lblAfterSorting.Name = "lblAfterSorting";
            this.lblAfterSorting.Size = new System.Drawing.Size(227, 323);
            this.lblAfterSorting.TabIndex = 1;
            this.lblAfterSorting.Text = "排序後";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(56, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "成績總和";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(259, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "成績平均";
            // 
            // btnSubjectSorting
            // 
            this.btnSubjectSorting.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubjectSorting.Location = new System.Drawing.Point(484, 130);
            this.btnSubjectSorting.Name = "btnSubjectSorting";
            this.btnSubjectSorting.Size = new System.Drawing.Size(105, 50);
            this.btnSubjectSorting.TabIndex = 6;
            this.btnSubjectSorting.Text = "科目排序";
            this.btnSubjectSorting.UseVisualStyleBackColor = true;
            this.btnSubjectSorting.Click += new System.EventHandler(this.Btn_SortBySubject_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSortByName.Location = new System.Drawing.Point(606, 130);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(105, 50);
            this.btnSortByName.TabIndex = 7;
            this.btnSortByName.Text = "姓名排序";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.Btn_SortByName_Click);
            // 
            // btnRankingOfGrades
            // 
            this.btnRankingOfGrades.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRankingOfGrades.Location = new System.Drawing.Point(606, 196);
            this.btnRankingOfGrades.Name = "btnRankingOfGrades";
            this.btnRankingOfGrades.Size = new System.Drawing.Size(105, 50);
            this.btnRankingOfGrades.TabIndex = 8;
            this.btnRankingOfGrades.Text = "成績排序";
            this.btnRankingOfGrades.UseVisualStyleBackColor = true;
            this.btnRankingOfGrades.Click += new System.EventHandler(this.Btn_SortByGrades_Click);
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNameSearch.Location = new System.Drawing.Point(606, 300);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(105, 50);
            this.btnNameSearch.TabIndex = 9;
            this.btnNameSearch.Text = "姓名搜尋";
            this.btnNameSearch.UseVisualStyleBackColor = true;
            this.btnNameSearch.Click += new System.EventHandler(this.Btn_NameSearch_Click);
            // 
            // tbNameInput
            // 
            this.tbNameInput.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbNameInput.Location = new System.Drawing.Point(482, 312);
            this.tbNameInput.Name = "tbNameInput";
            this.tbNameInput.Size = new System.Drawing.Size(108, 33);
            this.tbNameInput.TabIndex = 10;
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.BackColor = System.Drawing.Color.DarkGreen;
            this.lblAverageScore.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAverageScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAverageScore.Location = new System.Drawing.Point(259, 42);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(146, 36);
            this.lblAverageScore.TabIndex = 12;
            // 
            // lblSumOfResults
            // 
            this.lblSumOfResults.BackColor = System.Drawing.Color.DarkGreen;
            this.lblSumOfResults.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSumOfResults.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSumOfResults.Location = new System.Drawing.Point(56, 42);
            this.lblSumOfResults.Name = "lblSumOfResults";
            this.lblSumOfResults.Size = new System.Drawing.Size(146, 36);
            this.lblSumOfResults.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(484, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "身高排序";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_SortByHeight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(725, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSumOfResults);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.tbNameInput);
            this.Controls.Add(this.btnNameSearch);
            this.Controls.Add(this.btnRankingOfGrades);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.btnSubjectSorting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAfterSorting);
            this.Controls.Add(this.lblBeforeSorting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array的進階操作";
            this.Activated += new System.EventHandler(this.Form_Activated);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.BindingContextChanged += new System.EventHandler(this.Control_BindingContextChanged);
            this.VisibleChanged += new System.EventHandler(this.Control_VisibleChanged);
            this.HandleCreated += new System.EventHandler(this.Control_HandleCreated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeforeSorting;
        private System.Windows.Forms.Label lblAfterSorting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubjectSorting;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnRankingOfGrades;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.TextBox tbNameInput;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblSumOfResults;
        private System.Windows.Forms.Button button1;
    }
}

