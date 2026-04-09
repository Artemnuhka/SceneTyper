namespace SceneTyper
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
            richTextBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            новыйСценарийToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            размерОкнаToolStripMenuItem = new ToolStripMenuItem();
            полноэкранныйРежимToolStripMenuItem = new ToolStripMenuItem();
            оконныйToolStripMenuItem = new ToolStripMenuItem();
            важноНеВключатьОбаToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblProgress = new ToolStripStatusLabel();
            темаскороToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.MenuText;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBox1.ForeColor = SystemColors.Menu;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Multiline = true;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = ScrollBars.Both;
            richTextBox1.Size = new Size(1153, 584);
            richTextBox1.TabIndex = 0;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, видToolStripMenuItem, настройкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1153, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новыйСценарийToolStripMenuItem, сохранитьToolStripMenuItem, открытьToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // новыйСценарийToolStripMenuItem
            // 
            новыйСценарийToolStripMenuItem.Name = "новыйСценарийToolStripMenuItem";
            новыйСценарийToolStripMenuItem.Size = new Size(180, 22);
            новыйСценарийToolStripMenuItem.Text = "Новый сценарий";
            новыйСценарийToolStripMenuItem.Click += новыйСценарийToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(180, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(180, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { размерОкнаToolStripMenuItem, темаскороToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // размерОкнаToolStripMenuItem
            // 
            размерОкнаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { полноэкранныйРежимToolStripMenuItem, оконныйToolStripMenuItem, важноНеВключатьОбаToolStripMenuItem });
            размерОкнаToolStripMenuItem.Name = "размерОкнаToolStripMenuItem";
            размерОкнаToolStripMenuItem.Size = new Size(180, 22);
            размерОкнаToolStripMenuItem.Text = "Размер окна";
            // 
            // полноэкранныйРежимToolStripMenuItem
            // 
            полноэкранныйРежимToolStripMenuItem.CheckOnClick = true;
            полноэкранныйРежимToolStripMenuItem.Name = "полноэкранныйРежимToolStripMenuItem";
            полноэкранныйРежимToolStripMenuItem.Size = new Size(210, 22);
            полноэкранныйРежимToolStripMenuItem.Text = "Полноэкранный Режим";
            полноэкранныйРежимToolStripMenuItem.Click += полноэкранныйРежимToolStripMenuItem_Click;
            // 
            // оконныйToolStripMenuItem
            // 
            оконныйToolStripMenuItem.CheckOnClick = true;
            оконныйToolStripMenuItem.Name = "оконныйToolStripMenuItem";
            оконныйToolStripMenuItem.Size = new Size(210, 22);
            оконныйToolStripMenuItem.Text = "Оконный";
            оконныйToolStripMenuItem.Click += оконныйToolStripMenuItem_Click;
            // 
            // важноНеВключатьОбаToolStripMenuItem
            // 
            важноНеВключатьОбаToolStripMenuItem.Name = "важноНеВключатьОбаToolStripMenuItem";
            важноНеВключатьОбаToolStripMenuItem.Size = new Size(210, 22);
            важноНеВключатьОбаToolStripMenuItem.Text = "Важно! Не включать оба";
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(79, 20);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(180, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblProgress });
            statusStrip1.Location = new Point(0, 586);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1153, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblProgress
            // 
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(82, 17);
            lblProgress.Text = "Прогресс: 0%";
            // 
            // темаскороToolStripMenuItem
            // 
            темаскороToolStripMenuItem.Name = "темаскороToolStripMenuItem";
            темаскороToolStripMenuItem.Size = new Size(180, 22);
            темаскороToolStripMenuItem.Text = "Тема (скоро!)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 608);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "SceneTyper";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblProgress;
        private ToolStripMenuItem новыйСценарийToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem размерОкнаToolStripMenuItem;
        private ToolStripMenuItem полноэкранныйРежимToolStripMenuItem;
        private ToolStripMenuItem оконныйToolStripMenuItem;
        private ToolStripMenuItem важноНеВключатьОбаToolStripMenuItem;
        private ToolStripMenuItem темаскороToolStripMenuItem;
    }
}
