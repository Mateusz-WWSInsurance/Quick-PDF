namespace WWS_Trimmer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            exitButton = new Button();
            minimizeButton = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.WhiteSmoke;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = Color.WhiteSmoke;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(503, -2);
            exitButton.Name = "exitButton";
            exitButton.RightToLeft = RightToLeft.No;
            exitButton.Size = new Size(37, 35);
            exitButton.TabIndex = 11;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = Color.WhiteSmoke;
            minimizeButton.BackgroundImageLayout = ImageLayout.None;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.ForeColor = Color.WhiteSmoke;
            minimizeButton.Image = (Image)resources.GetObject("minimizeButton.Image");
            minimizeButton.Location = new Point(471, -2);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.RightToLeft = RightToLeft.No;
            minimizeButton.Size = new Size(31, 35);
            minimizeButton.TabIndex = 12;
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.Location = new Point(118, 529);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 15;
            button2.Text = "O programie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.AllowDrop = true;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.Location = new Point(274, 529);
            button4.Name = "button4";
            button4.Size = new Size(150, 29);
            button4.TabIndex = 16;
            button4.Text = "Zgłoś błąd";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.AllowDrop = true;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(94, 124);
            button5.Name = "button5";
            button5.Size = new Size(160, 160);
            button5.TabIndex = 18;
            button5.Text = "Scalanie PDF";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // button6
            // 
            button6.AllowDrop = true;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(94, 305);
            button6.Name = "button6";
            button6.Size = new Size(160, 160);
            button6.TabIndex = 19;
            button6.Text = "Kompresja PDF";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 506);
            label6.Name = "label6";
            label6.Size = new Size(242, 20);
            label6.TabIndex = 20;
            label6.Text = "Quick PDF v. 2.0.9 |  WWS Insurance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(163, 60);
            label7.Name = "label7";
            label7.Size = new Size(217, 38);
            label7.TabIndex = 21;
            label7.Text = "Co dziś robimy?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(-4, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 39);
            panel1.TabIndex = 22;
            // 
            // button7
            // 
            button7.AllowDrop = true;
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(275, 124);
            button7.Name = "button7";
            button7.Size = new Size(160, 160);
            button7.TabIndex = 23;
            button7.Text = "Wycinanie PDF";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.AllowDrop = true;
            button8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(275, 305);
            button8.Name = "button8";
            button8.Size = new Size(160, 160);
            button8.TabIndex = 24;
            button8.Text = "Obracanie PDF";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(543, 566);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(minimizeButton);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quick PDF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button exitButton;
        private Button minimizeButton;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button button7;
        private Button button8;
    }
}
