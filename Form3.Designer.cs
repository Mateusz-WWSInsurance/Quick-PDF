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
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.WhiteSmoke;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = Color.WhiteSmoke;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(364, -3);
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
            chooseFileButton.Location = new Point(126, 95);
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
            maxCompressButton.Location = new Point(150, 178);
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
            label2.Location = new Point(12, 50);
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
            panel1.Size = new Size(413, 39);
            panel1.TabIndex = 24;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(405, 254);
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
    }
}