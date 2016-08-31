namespace CMPT354_Ass3
{
    partial class searchForm
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
            this.searchOnlyGrid = new System.Windows.Forms.DataGridView();
            this.numberSearch2 = new System.Windows.Forms.TextBox();
            this.term_combo2 = new System.Windows.Forms.ComboBox();
            this.depart_combo2 = new System.Windows.Forms.ComboBox();
            this.level_combo2 = new System.Windows.Forms.ComboBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.search2_btn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchOnlyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchOnlyGrid
            // 
            this.searchOnlyGrid.AllowUserToAddRows = false;
            this.searchOnlyGrid.AllowUserToDeleteRows = false;
            this.searchOnlyGrid.AllowUserToOrderColumns = true;
            this.searchOnlyGrid.AllowUserToResizeRows = false;
            this.searchOnlyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchOnlyGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.searchOnlyGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.searchOnlyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchOnlyGrid.Location = new System.Drawing.Point(20, 185);
            this.searchOnlyGrid.Name = "searchOnlyGrid";
            this.searchOnlyGrid.ReadOnly = true;
            this.searchOnlyGrid.RowHeadersVisible = false;
            this.searchOnlyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchOnlyGrid.Size = new System.Drawing.Size(582, 328);
            this.searchOnlyGrid.TabIndex = 0;
            // 
            // numberSearch2
            // 
            this.numberSearch2.Location = new System.Drawing.Point(249, 114);
            this.numberSearch2.Name = "numberSearch2";
            this.numberSearch2.Size = new System.Drawing.Size(121, 20);
            this.numberSearch2.TabIndex = 1;
            // 
            // term_combo2
            // 
            this.term_combo2.FormattingEnabled = true;
            this.term_combo2.Items.AddRange(new object[] {
            "2014 FALL"});
            this.term_combo2.Location = new System.Drawing.Point(249, 24);
            this.term_combo2.Name = "term_combo2";
            this.term_combo2.Size = new System.Drawing.Size(121, 21);
            this.term_combo2.TabIndex = 2;
            // 
            // depart_combo2
            // 
            this.depart_combo2.FormattingEnabled = true;
            this.depart_combo2.Items.AddRange(new object[] {
            "All Departments"});
            this.depart_combo2.Location = new System.Drawing.Point(249, 51);
            this.depart_combo2.Name = "depart_combo2";
            this.depart_combo2.Size = new System.Drawing.Size(121, 21);
            this.depart_combo2.TabIndex = 3;
            // 
            // level_combo2
            // 
            this.level_combo2.FormattingEnabled = true;
            this.level_combo2.Items.AddRange(new object[] {
            "All Course Level"});
            this.level_combo2.Location = new System.Drawing.Point(249, 87);
            this.level_combo2.Name = "level_combo2";
            this.level_combo2.Size = new System.Drawing.Size(121, 21);
            this.level_combo2.TabIndex = 4;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(221, 140);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 39);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // search2_btn
            // 
            this.search2_btn.Location = new System.Drawing.Point(302, 140);
            this.search2_btn.Name = "search2_btn";
            this.search2_btn.Size = new System.Drawing.Size(75, 39);
            this.search2_btn.TabIndex = 6;
            this.search2_btn.Text = "Search";
            this.search2_btn.UseVisualStyleBackColor = true;
            this.search2_btn.Click += new System.EventHandler(this.search2_btn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(516, 141);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(85, 37);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "Return to Main";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(619, 531);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.search2_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.level_combo2);
            this.Controls.Add(this.depart_combo2);
            this.Controls.Add(this.term_combo2);
            this.Controls.Add(this.numberSearch2);
            this.Controls.Add(this.searchOnlyGrid);
            this.Name = "searchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Course Search Only Mode";
            ((System.ComponentModel.ISupportInitialize)(this.searchOnlyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchOnlyGrid;
        private System.Windows.Forms.TextBox numberSearch2;
        private System.Windows.Forms.ComboBox term_combo2;
        private System.Windows.Forms.ComboBox depart_combo2;
        private System.Windows.Forms.ComboBox level_combo2;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button search2_btn;
        private System.Windows.Forms.Button backbtn;

    }
}