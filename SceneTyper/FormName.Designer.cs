namespace SceneTyper
{
    partial class FormName
    {
        public string ScenarioName => tbName.Text;

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Название не может быть пустым!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; // Это наш сигнал для "вернуться назад"
            this.Close();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormName));
            label1 = new Label();
            tbName = new TextBox();
            btnDone = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 30);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 0;
            label1.Text = "Теперь введите название проекта:";
            // 
            // tbName
            // 
            tbName.Location = new Point(66, 84);
            tbName.Name = "tbName";
            tbName.Size = new Size(194, 23);
            tbName.TabIndex = 1;
            // 
            // btnDone
            // 
            btnDone.Location = new Point(185, 147);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(75, 23);
            btnDone.TabIndex = 2;
            btnDone.Text = "Готово";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(66, 147);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 182);
            Controls.Add(btnBack);
            Controls.Add(btnDone);
            Controls.Add(tbName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormName";
            Text = "Name of your project";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private Button btnDone;
        private Button btnBack;
    }
}