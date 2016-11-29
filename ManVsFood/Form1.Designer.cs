namespace ManVsFood
{
    partial class Form_MVF
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
            this.components = new System.ComponentModel.Container();
            this.lb_Items = new System.Windows.Forms.ListBox();
            this.lb_AddedItems = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MVF = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timerLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Items
            // 
            this.lb_Items.FormattingEnabled = true;
            this.lb_Items.Location = new System.Drawing.Point(7, 79);
            this.lb_Items.Margin = new System.Windows.Forms.Padding(2);
            this.lb_Items.Name = "lb_Items";
            this.lb_Items.Size = new System.Drawing.Size(156, 342);
            this.lb_Items.TabIndex = 0;
            // 
            // lb_AddedItems
            // 
            this.lb_AddedItems.FormattingEnabled = true;
            this.lb_AddedItems.Location = new System.Drawing.Point(262, 79);
            this.lb_AddedItems.Margin = new System.Windows.Forms.Padding(2);
            this.lb_AddedItems.Name = "lb_AddedItems";
            this.lb_AddedItems.Size = new System.Drawing.Size(156, 342);
            this.lb_AddedItems.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(182, 201);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(60, 24);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(182, 238);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(60, 24);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(182, 276);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(60, 24);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(710, 353);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(60, 24);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(710, 381);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(60, 24);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.BackgroundImage = global::ManVsFood.Properties.Resources.photo_2015_05_19_09_58_48;
            this.timerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerLabel.Location = new System.Drawing.Point(472, 79);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(2);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(236, 212);
            this.timerLabel.TabIndex = 7;
            this.timerLabel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 359);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Challenge Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cost of Failure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // lbl_MVF
            // 
            this.lbl_MVF.AutoSize = true;
            this.lbl_MVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MVF.Location = new System.Drawing.Point(96, 24);
            this.lbl_MVF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MVF.Name = "lbl_MVF";
            this.lbl_MVF.Size = new System.Drawing.Size(244, 44);
            this.lbl_MVF.TabIndex = 12;
            this.lbl_MVF.Text = "Man Vs Food";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDisplay
            // 
            this.timerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerDisplay.Location = new System.Drawing.Point(573, 353);
            this.timerDisplay.Name = "timerDisplay";
            this.timerDisplay.Size = new System.Drawing.Size(100, 23);
            this.timerDisplay.TabIndex = 13;
            this.timerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerDisplay.Click += new System.EventHandler(this.timerDisplay_Click);
            // 
            // Form_MVF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 432);
            this.Controls.Add(this.timerDisplay);
            this.Controls.Add(this.lbl_MVF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_AddedItems);
            this.Controls.Add(this.lb_Items);
            this.Controls.Add(this.timerLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_MVF";
            this.Text = "Man Vs Food";
            ((System.ComponentModel.ISupportInitialize)(this.timerLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Items;
        private System.Windows.Forms.ListBox lb_AddedItems;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox timerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MVF;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerDisplay;
    }
}

