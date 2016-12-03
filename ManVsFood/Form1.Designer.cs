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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MVF));
            this.lb_Items = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lbl_ChallengeDurationStatic = new System.Windows.Forms.Label();
            this.lbl_CostOfFailureStatic = new System.Windows.Forms.Label();
            this.lbl_ChallengeTime = new System.Windows.Forms.Label();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_MVF = new System.Windows.Forms.Label();
            this.lbl_SelectChallengeStatic = new System.Windows.Forms.Label();
            this.lbl_DescribeStatic = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerDisplay = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.TimerLabelText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Items
            // 
            this.lb_Items.DisplayMember = "challengename";
            this.lb_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Items.FormattingEnabled = true;
            this.lb_Items.ItemHeight = 16;
            this.lb_Items.Location = new System.Drawing.Point(14, 74);
            this.lb_Items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Items.Name = "lb_Items";
            this.lb_Items.Size = new System.Drawing.Size(207, 324);
            this.lb_Items.TabIndex = 0;
            this.lb_Items.SelectedIndexChanged += new System.EventHandler(this.lb_Items_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(30, 421);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(168, 44);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add a New Challenge";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(580, 364);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(129, 39);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(725, 421);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(129, 39);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(286, 74);
            this.picBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox.MaximumSize = new System.Drawing.Size(437, 402);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(233, 216);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // lbl_ChallengeDurationStatic
            // 
            this.lbl_ChallengeDurationStatic.AutoSize = true;
            this.lbl_ChallengeDurationStatic.Location = new System.Drawing.Point(581, 273);
            this.lbl_ChallengeDurationStatic.Name = "lbl_ChallengeDurationStatic";
            this.lbl_ChallengeDurationStatic.Size = new System.Drawing.Size(133, 17);
            this.lbl_ChallengeDurationStatic.TabIndex = 8;
            this.lbl_ChallengeDurationStatic.Text = "Challenge Duration:";
            // 
            // lbl_CostOfFailureStatic
            // 
            this.lbl_CostOfFailureStatic.AutoSize = true;
            this.lbl_CostOfFailureStatic.Location = new System.Drawing.Point(612, 307);
            this.lbl_CostOfFailureStatic.Name = "lbl_CostOfFailureStatic";
            this.lbl_CostOfFailureStatic.Size = new System.Drawing.Size(103, 17);
            this.lbl_CostOfFailureStatic.TabIndex = 9;
            this.lbl_CostOfFailureStatic.Text = "Cost of Failure:";
            // 
            // lbl_ChallengeTime
            // 
            this.lbl_ChallengeTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ChallengeTime.Location = new System.Drawing.Point(722, 273);
            this.lbl_ChallengeTime.Name = "lbl_ChallengeTime";
            this.lbl_ChallengeTime.Size = new System.Drawing.Size(135, 24);
            this.lbl_ChallengeTime.TabIndex = 8;
            this.lbl_ChallengeTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Cost.Location = new System.Drawing.Point(721, 306);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(135, 24);
            this.lbl_Cost.TabIndex = 9;
            this.lbl_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_MVF
            // 
            this.lbl_MVF.AutoSize = true;
            this.lbl_MVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MVF.Location = new System.Drawing.Point(308, 9);
            this.lbl_MVF.Name = "lbl_MVF";
            this.lbl_MVF.Size = new System.Drawing.Size(244, 44);
            this.lbl_MVF.TabIndex = 12;
            this.lbl_MVF.Text = "Man Vs Food";
            // 
            // lbl_SelectChallengeStatic
            // 
            this.lbl_SelectChallengeStatic.AutoSize = true;
            this.lbl_SelectChallengeStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectChallengeStatic.Location = new System.Drawing.Point(11, 45);
            this.lbl_SelectChallengeStatic.Name = "lbl_SelectChallengeStatic";
            this.lbl_SelectChallengeStatic.Size = new System.Drawing.Size(212, 17);
            this.lbl_SelectChallengeStatic.TabIndex = 13;
            this.lbl_SelectChallengeStatic.Text = "Select a Challenge From the List";
            // 
            // lbl_DescribeStatic
            // 
            this.lbl_DescribeStatic.AutoSize = true;
            this.lbl_DescribeStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescribeStatic.Location = new System.Drawing.Point(365, 292);
            this.lbl_DescribeStatic.Name = "lbl_DescribeStatic";
            this.lbl_DescribeStatic.Size = new System.Drawing.Size(79, 17);
            this.lbl_DescribeStatic.TabIndex = 14;
            this.lbl_DescribeStatic.Text = "Description";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(286, 321);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(234, 157);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDisplay
            // 
            this.timerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerDisplay.Location = new System.Drawing.Point(580, 74);
            this.timerDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerDisplay.Name = "timerDisplay";
            this.timerDisplay.Size = new System.Drawing.Size(293, 171);
            this.timerDisplay.TabIndex = 7;
            this.timerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(580, 421);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(128, 39);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(725, 364);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(129, 39);
            this.pauseButton.TabIndex = 4;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // TimerLabelText
            // 
            this.TimerLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabelText.Location = new System.Drawing.Point(697, 45);
            this.TimerLabelText.Name = "TimerLabelText";
            this.TimerLabelText.Size = new System.Drawing.Size(44, 17);
            this.TimerLabelText.TabIndex = 21;
            this.TimerLabelText.Text = "Timer";
            // 
            // Form_MVF
            // 
            this.AcceptButton = this.btn_Start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(884, 488);
            this.Controls.Add(this.TimerLabelText);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.timerDisplay);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.lbl_DescribeStatic);
            this.Controls.Add(this.lbl_SelectChallengeStatic);
            this.Controls.Add(this.lbl_MVF);
            this.Controls.Add(this.lbl_Cost);
            this.Controls.Add(this.lbl_ChallengeTime);
            this.Controls.Add(this.lbl_CostOfFailureStatic);
            this.Controls.Add(this.lbl_ChallengeDurationStatic);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_Items);
            this.Controls.Add(this.picBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MVF";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Man Vs Food";
            this.Load += new System.EventHandler(this.Form_MVF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Items;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lbl_ChallengeDurationStatic;
        private System.Windows.Forms.Label lbl_CostOfFailureStatic;
        private System.Windows.Forms.Label lbl_ChallengeTime;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label lbl_MVF;
        private System.Windows.Forms.Label lbl_SelectChallengeStatic;
        private System.Windows.Forms.Label lbl_DescribeStatic;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerDisplay;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label TimerLabelText;
    }
}

