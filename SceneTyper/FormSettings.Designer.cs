namespace SceneTyper
{
    partial class FormSettings
    {
        // Это свойство позволит главному окну узнать, сколько минут ввел юзер
        public int Minutes => (int)numMinutes.Value;

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            numMinutes = new NumericUpDown();
            btnNext = new Button();
            label1 = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numMinutes).BeginInit();
            SuspendLayout();
            // 
            // numMinutes
            // 
            numMinutes.Location = new Point(50, 78);
            numMinutes.Name = "numMinutes";
            numMinutes.Size = new Size(120, 23);
            numMinutes.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(135, 117);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 1;
            btnNext.Text = "След.";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 57);
            label1.TabIndex = 2;
            label1.Text = "Введите примерное время на сколько вы хотите сделать сценарий (в минутах):";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(21, 117);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 152);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(numMinutes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSettings";
            Text = "Time of Scene";
            ((System.ComponentModel.ISupportInitialize)numMinutes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numMinutes;
        private Button btnNext;
        private Label label1;
        private Button btnCancel;
    }
}