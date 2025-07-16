namespace WinFormsApp1
{
    partial class ApplicantHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantHomePage));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 101);
            label1.Name = "label1";
            label1.Size = new Size(159, 26);
            label1.TabIndex = 16;
            label1.Text = "Career Connect DB";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(237, 153);
            button1.Name = "button1";
            button1.Size = new Size(220, 48);
            button1.TabIndex = 17;
            button1.Text = "View job listings";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(237, 223);
            button2.Name = "button2";
            button2.Size = new Size(220, 48);
            button2.TabIndex = 18;
            button2.Text = "View notifications";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(720, 414);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form5";
            Text = "Job Seeker Portal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}