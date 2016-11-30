namespace ManVsFood
{
    partial class Form_ChallengeInfo
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
            this.btn2_Browse = new System.Windows.Forms.Button();
            this.btn2_Save = new System.Windows.Forms.Button();
            this.btn2_Exit = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txt2_Image = new System.Windows.Forms.TextBox();
            this.lbl2_Image = new System.Windows.Forms.Label();
            this.cb_Duration = new System.Windows.Forms.ComboBox();
            this.txt2_Price = new System.Windows.Forms.TextBox();
            this.txt2_Calories = new System.Windows.Forms.TextBox();
            this.txt2_Description = new System.Windows.Forms.TextBox();
            this.txt_ChallengeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl2_Price = new System.Windows.Forms.Label();
            this.lbl2_Calories = new System.Windows.Forms.Label();
            this.lbl2_ShortDesc = new System.Windows.Forms.Label();
            this.lbl2_ChallengeName = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn2_Browse
            // 
            this.btn2_Browse.Location = new System.Drawing.Point(407, 245);
            this.btn2_Browse.Name = "btn2_Browse";
            this.btn2_Browse.Size = new System.Drawing.Size(110, 36);
            this.btn2_Browse.TabIndex = 11;
            this.btn2_Browse.Text = "Browse";
            this.btn2_Browse.UseVisualStyleBackColor = true;
            this.btn2_Browse.Click += new System.EventHandler(this.btn2_Browse_Click);
            // 
            // btn2_Save
            // 
            this.btn2_Save.Location = new System.Drawing.Point(303, 377);
            this.btn2_Save.Name = "btn2_Save";
            this.btn2_Save.Size = new System.Drawing.Size(110, 36);
            this.btn2_Save.TabIndex = 13;
            this.btn2_Save.Text = "Save";
            this.btn2_Save.UseVisualStyleBackColor = true;
            this.btn2_Save.Click += new System.EventHandler(this.btn2_Save_Click);
            // 
            // btn2_Exit
            // 
            this.btn2_Exit.Location = new System.Drawing.Point(447, 377);
            this.btn2_Exit.Name = "btn2_Exit";
            this.btn2_Exit.Size = new System.Drawing.Size(110, 36);
            this.btn2_Exit.TabIndex = 14;
            this.btn2_Exit.Text = "Exit";
            this.btn2_Exit.UseVisualStyleBackColor = true;
            this.btn2_Exit.Click += new System.EventHandler(this.btn2_Exit_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txt2_Image);
            this.groupBox.Controls.Add(this.lbl2_Image);
            this.groupBox.Controls.Add(this.cb_Duration);
            this.groupBox.Controls.Add(this.btn2_Browse);
            this.groupBox.Controls.Add(this.txt2_Price);
            this.groupBox.Controls.Add(this.txt2_Calories);
            this.groupBox.Controls.Add(this.txt2_Description);
            this.groupBox.Controls.Add(this.txt_ChallengeName);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.lbl2_Price);
            this.groupBox.Controls.Add(this.lbl2_Calories);
            this.groupBox.Controls.Add(this.lbl2_ShortDesc);
            this.groupBox.Controls.Add(this.lbl2_ChallengeName);
            this.groupBox.Location = new System.Drawing.Point(12, 46);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(545, 303);
            this.groupBox.TabIndex = 15;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Information";
            // 
            // txt2_Image
            // 
            this.txt2_Image.Location = new System.Drawing.Point(180, 252);
            this.txt2_Image.Name = "txt2_Image";
            this.txt2_Image.Size = new System.Drawing.Size(171, 29);
            this.txt2_Image.TabIndex = 24;
            // 
            // lbl2_Image
            // 
            this.lbl2_Image.AutoSize = true;
            this.lbl2_Image.Location = new System.Drawing.Point(16, 257);
            this.lbl2_Image.Name = "lbl2_Image";
            this.lbl2_Image.Size = new System.Drawing.Size(66, 25);
            this.lbl2_Image.TabIndex = 23;
            this.lbl2_Image.Text = "Image";
            // 
            // cb_Duration
            // 
            this.cb_Duration.FormattingEnabled = true;
            this.cb_Duration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_Duration.Location = new System.Drawing.Point(180, 209);
            this.cb_Duration.Name = "cb_Duration";
            this.cb_Duration.Size = new System.Drawing.Size(171, 32);
            this.cb_Duration.TabIndex = 22;
            // 
            // txt2_Price
            // 
            this.txt2_Price.Location = new System.Drawing.Point(180, 162);
            this.txt2_Price.Name = "txt2_Price";
            this.txt2_Price.Size = new System.Drawing.Size(171, 29);
            this.txt2_Price.TabIndex = 21;
            // 
            // txt2_Calories
            // 
            this.txt2_Calories.Location = new System.Drawing.Point(180, 120);
            this.txt2_Calories.Name = "txt2_Calories";
            this.txt2_Calories.Size = new System.Drawing.Size(171, 29);
            this.txt2_Calories.TabIndex = 20;
            // 
            // txt2_Description
            // 
            this.txt2_Description.Location = new System.Drawing.Point(180, 75);
            this.txt2_Description.Name = "txt2_Description";
            this.txt2_Description.Size = new System.Drawing.Size(171, 29);
            this.txt2_Description.TabIndex = 19;
            // 
            // txt_ChallengeName
            // 
            this.txt_ChallengeName.Location = new System.Drawing.Point(180, 33);
            this.txt_ChallengeName.Name = "txt_ChallengeName";
            this.txt_ChallengeName.Size = new System.Drawing.Size(171, 29);
            this.txt_ChallengeName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Duration";
            // 
            // lbl2_Price
            // 
            this.lbl2_Price.AutoSize = true;
            this.lbl2_Price.Location = new System.Drawing.Point(16, 162);
            this.lbl2_Price.Name = "lbl2_Price";
            this.lbl2_Price.Size = new System.Drawing.Size(56, 25);
            this.lbl2_Price.TabIndex = 16;
            this.lbl2_Price.Text = "Price";
            // 
            // lbl2_Calories
            // 
            this.lbl2_Calories.AutoSize = true;
            this.lbl2_Calories.Location = new System.Drawing.Point(16, 120);
            this.lbl2_Calories.Name = "lbl2_Calories";
            this.lbl2_Calories.Size = new System.Drawing.Size(139, 25);
            this.lbl2_Calories.TabIndex = 15;
            this.lbl2_Calories.Text = "Total Calories:";
            // 
            // lbl2_ShortDesc
            // 
            this.lbl2_ShortDesc.AutoSize = true;
            this.lbl2_ShortDesc.Location = new System.Drawing.Point(16, 75);
            this.lbl2_ShortDesc.Name = "lbl2_ShortDesc";
            this.lbl2_ShortDesc.Size = new System.Drawing.Size(161, 25);
            this.lbl2_ShortDesc.TabIndex = 14;
            this.lbl2_ShortDesc.Text = "Short Description";
            // 
            // lbl2_ChallengeName
            // 
            this.lbl2_ChallengeName.AutoSize = true;
            this.lbl2_ChallengeName.Location = new System.Drawing.Point(16, 36);
            this.lbl2_ChallengeName.Name = "lbl2_ChallengeName";
            this.lbl2_ChallengeName.Size = new System.Drawing.Size(158, 25);
            this.lbl2_ChallengeName.TabIndex = 13;
            this.lbl2_ChallengeName.Text = "Challenge Name";
            // 
            // Form_ChallengeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btn2_Exit);
            this.Controls.Add(this.btn2_Save);
            this.Name = "Form_ChallengeInfo";
            this.Text = "Enter Challenge Information";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn2_Browse;
        private System.Windows.Forms.Button btn2_Save;
        private System.Windows.Forms.Button btn2_Exit;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txt2_Image;
        private System.Windows.Forms.Label lbl2_Image;
        private System.Windows.Forms.ComboBox cb_Duration;
        private System.Windows.Forms.TextBox txt2_Price;
        private System.Windows.Forms.TextBox txt2_Calories;
        private System.Windows.Forms.TextBox txt2_Description;
        private System.Windows.Forms.TextBox txt_ChallengeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl2_Price;
        private System.Windows.Forms.Label lbl2_Calories;
        private System.Windows.Forms.Label lbl2_ShortDesc;
        private System.Windows.Forms.Label lbl2_ChallengeName;
    }
}