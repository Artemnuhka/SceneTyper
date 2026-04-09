namespace SceneTyper
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btnClose = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(188, 12);
            label1.Name = "label1";
            label1.Size = new Size(600, 90);
            label1.TabIndex = 1;
            label1.Text = "Абсолютно ВЕСЬ проект был построен с помощью Gemini и моих небольших знаний C#  ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(1033, 134);
            label2.TabIndex = 2;
            label2.Text = "Вайбкодер: skrih099                                       тгк: https://t.me/skrihmychannel";
            // 
            // label3
            // 
            label3.Location = new Point(12, 399);
            label3.Name = "label3";
            label3.Size = new Size(169, 33);
            label3.TabIndex = 3;
            label3.Text = "Благодарю за использование моей программы!";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 236);
            label4.Name = "label4";
            label4.Size = new Size(350, 163);
            label4.TabIndex = 4;
            label4.Text = "Программа SceneTyper была создана ИСКЛЮЧИТЕЛЬНО для создания сценариев для ваших роликов";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(402, 228);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(354, 204);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(225, 400);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 32);
            btnClose.TabIndex = 6;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(747, 426);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 7;
            label5.Text = "ver 1.0";
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnClose);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInfo";
            Text = "Information";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Button btnClose;
        private Label label5;
    }
}