using System;
using System.Windows.Forms;
using System.IO;

namespace SceneTyper
{
    public partial class Form1 : Form
    {
        private int targetChars = 0;

        public Form1()
        {
            InitializeComponent();
            // Эта строчка принудительно привязывает крестик к твоему коду:
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void SaveFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, richTextBox1.Text);
                    MessageBox.Show("Файл успешно сохранен!");
                }
            }
        }

        private void новыйСценарийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool finished = false;
            int mins = 1;
            string name = "";

            while (!finished)
            {
                using (var fMins = new FormSettings())
                {
                    if (fMins.ShowDialog() != DialogResult.OK) return;
                    mins = fMins.Minutes;
                }

                using (var fName = new FormName())
                {
                    var res = fName.ShowDialog();
                    if (res == DialogResult.Retry) continue;
                    if (res != DialogResult.OK) return;

                    name = fName.ScenarioName;
                    finished = true;
                }
            }

            targetChars = mins * 1500;
            this.Text = "Сценарий: " + name;
            richTextBox1.Clear();
            lblProgress.Text = "Прогресс: 0%";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (targetChars > 0)
            {
                double proc = (double)richTextBox1.Text.Length / targetChars * 100;
                if (proc > 100) proc = 100;
                lblProgress.Text = $"Прогресс: {Math.Round(proc, 1)}%";
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Текстовые файлы (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(ofd.FileName);
                    this.Text = "Сценарий: " + Path.GetFileName(ofd.FileName);
                }
            }
        }

        // Этот метод сработает при нажатии на крестик
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если текста нет, закрываемся молча
            if (string.IsNullOrWhiteSpace(richTextBox1.Text)) return;

            var result = MessageBox.Show("Убедитесь, что вы сохранились! Сохранить изменения перед выходом?",
                                        "Выход",
                                        MessageBoxButtons.YesNoCancel,
                                        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SaveFile();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // Отменяем закрытие
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void размерОкнаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оконныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Если окно уже на весь экран — возвращаем в обычный размер
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // Если окно маленькое — разворачиваем до панели задач
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void полноэкранныйРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                // Возвращаем как было
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                menuStrip1.Visible = true; // Показываем меню обратно
            }
            else
            {
                // Включаем полный экран
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                // Можно скрыть меню, чтобы не отвлекало, но тогда выход только по горячей клавише
                // menuStrip1.Visible = false; 
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем новое окно информации
            FormInfo info = new FormInfo();

            // Показываем его как модальное окно (пока не закроешь, в главное не вернешься)
            info.ShowDialog();
        }
    }
}