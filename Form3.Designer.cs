namespace WWS_Trimmer
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            exitButton = new Button();
            chooseFileButton = new Button();
            maxCompressButton = new Button();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.WhiteSmoke;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = Color.WhiteSmoke;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(523, -3);
            exitButton.Name = "exitButton";
            exitButton.RightToLeft = RightToLeft.No;
            exitButton.Size = new Size(37, 39);
            exitButton.TabIndex = 12;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // chooseFileButton
            // 
            chooseFileButton.AllowDrop = true;
            chooseFileButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chooseFileButton.Location = new Point(12, 75);
            chooseFileButton.Name = "chooseFileButton";
            chooseFileButton.Size = new Size(150, 29);
            chooseFileButton.TabIndex = 13;
            chooseFileButton.Text = "Wybierz PDF";
            chooseFileButton.UseVisualStyleBackColor = true;
            chooseFileButton.Click += chooseFileButton_Click;
            // 
            // maxCompressButton
            // 
            maxCompressButton.AllowDrop = true;
            maxCompressButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            maxCompressButton.Location = new Point(227, 221);
            maxCompressButton.Name = "maxCompressButton";
            maxCompressButton.Size = new Size(108, 49);
            maxCompressButton.TabIndex = 15;
            maxCompressButton.Text = "Kompresuj";
            maxCompressButton.UseVisualStyleBackColor = true;
            maxCompressButton.Click += maxCompressButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(383, 20);
            label2.TabIndex = 17;
            label2.Text = "Wybrany PDF: Brak - skorzystaj z poniższego przycisku";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 39);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 142);
            label1.Name = "label1";
            label1.Size = new Size(481, 17);
            label1.TabIndex = 25;
            label1.Text = "Kompresor korzysta z technologii Syncfusion, która nie należy do WWS Insurance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(542, 17);
            label3.TabIndex = 26;
            label3.Text = "W związku z powyższym na pliku pdf zostanie umieszczona adnotacja dot. użycia syncfusion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(443, 17);
            label4.TabIndex = 27;
            label4.Text = "Plik PDF zostanie zapisany jako nowy plik, oryginalny pozostanie bez zmian";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(561, 282);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(maxCompressButton);
            Controls.Add(chooseFileButton);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kompresowanie PDF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button chooseFileButton;
        private Button maxCompressButton;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}