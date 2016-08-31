namespace CMPT354_Ass3
{
    partial class Start_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.SID_Text = new System.Windows.Forms.TextBox();
            this.SPW_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTerm_Combo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(328, 319);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 161;
            this.lineShape1.X2 = 161;
            this.lineShape1.Y1 = 182;
            this.lineShape1.Y2 = 310;
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(171, 278);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(145, 36);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Log In";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(19, 277);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(136, 37);
            this.Search_Button.TabIndex = 5;
            this.Search_Button.Text = "Search Courses";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // SID_Text
            // 
            this.SID_Text.Location = new System.Drawing.Point(171, 204);
            this.SID_Text.Name = "SID_Text";
            this.SID_Text.Size = new System.Drawing.Size(145, 20);
            this.SID_Text.TabIndex = 6;
            // 
            // SPW_Text
            // 
            this.SPW_Text.Location = new System.Drawing.Point(171, 244);
            this.SPW_Text.Name = "SPW_Text";
            this.SPW_Text.Size = new System.Drawing.Size(145, 20);
            this.SPW_Text.TabIndex = 7;
            this.SPW_Text.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // SearchTerm_Combo
            // 
            this.SearchTerm_Combo.FormattingEnabled = true;
            this.SearchTerm_Combo.Items.AddRange(new object[] {
            "2014 FALL"});
            this.SearchTerm_Combo.Location = new System.Drawing.Point(26, 226);
            this.SearchTerm_Combo.Name = "SearchTerm_Combo";
            this.SearchTerm_Combo.Size = new System.Drawing.Size(121, 21);
            this.SearchTerm_Combo.TabIndex = 10;
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(328, 319);
            this.Controls.Add(this.SearchTerm_Combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SPW_Text);
            this.Controls.Add(this.SID_Text);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Start_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.TextBox SID_Text;
        private System.Windows.Forms.TextBox SPW_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SearchTerm_Combo;
    }
}

