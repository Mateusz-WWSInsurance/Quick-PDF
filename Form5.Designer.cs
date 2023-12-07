namespace WWS_Trimmer
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            exitButton = new Button();
            panel1 = new Panel();
            label6 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(12, 50);
            label5.Name = "label5";
            label5.Size = new Size(383, 20);
            label5.TabIndex = 18;
            label5.Text = "Wybrany PDF: Brak - skorzystaj z poniższego przycisku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(123, 142);
            label4.Name = "label4";
            label4.Size = new Size(190, 20);
            label4.TabIndex = 17;
            label4.Text = "Zakres stron do przycięcia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 202);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 16;
            label3.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(244, 175);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 15;
            label2.Text = "Do";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(165, 175);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 14;
            label1.Text = "Od";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(36, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(36, 27);
            textBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(12, 73);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 11;
            button1.Text = "Wybierz PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.Location = new Point(81, 271);
            button3.Name = "button3";
            button3.Size = new Size(285, 52);
            button3.TabIndex = 19;
            button3.Text = "Przytnij";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.WhiteSmoke;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = Color.WhiteSmoke;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(395, 0);
            exitButton.Name = "exitButton";
            exitButton.RightToLeft = RightToLeft.No;
            exitButton.Size = new Size(37, 35);
            exitButton.TabIndex = 23;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 39);
            panel1.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(70, 334);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 30;
            label6.Text = "  ";
            // 
            // Form5
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(436, 368);
            Controls.Add(label6);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button3;
        private Button exitButton;
        private Panel panel1;
        private Label label6;
    }
}