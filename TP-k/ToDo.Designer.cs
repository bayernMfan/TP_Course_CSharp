namespace TP_k
{
    partial class ToDo
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TasksCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TasklistLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.InWorkTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(22, 30);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(301, 229);
            this.DescriptionRichTextBox.TabIndex = 0;
            this.DescriptionRichTextBox.Text = "";
            // 
            // TasksCheckedListBox
            // 
            this.TasksCheckedListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TasksCheckedListBox.Location = new System.Drawing.Point(329, 30);
            this.TasksCheckedListBox.Name = "TasksCheckedListBox";
            this.TasksCheckedListBox.Size = new System.Drawing.Size(75, 229);
            this.TasksCheckedListBox.TabIndex = 1;
            this.TasksCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.TasksCheckedListBox_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAdd.Location = new System.Drawing.Point(329, 265);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.Location = new System.Drawing.Point(329, 294);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonSave.Location = new System.Drawing.Point(248, 265);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DescriptionLabel.Location = new System.Drawing.Point(263, 10);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description";
            // 
            // TasklistLabel
            // 
            this.TasklistLabel.AutoSize = true;
            this.TasklistLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TasklistLabel.Location = new System.Drawing.Point(329, 10);
            this.TasklistLabel.Name = "TasklistLabel";
            this.TasklistLabel.Size = new System.Drawing.Size(46, 13);
            this.TasklistLabel.TabIndex = 6;
            this.TasklistLabel.Text = "Task list";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "exampleBTN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InWorkTxtBox
            // 
            this.InWorkTxtBox.Location = new System.Drawing.Point(22, 294);
            this.InWorkTxtBox.Name = "InWorkTxtBox";
            this.InWorkTxtBox.ReadOnly = true;
            this.InWorkTxtBox.Size = new System.Drawing.Size(301, 20);
            this.InWorkTxtBox.TabIndex = 9;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.InWorkTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TasklistLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.TasksCheckedListBox);
            this.Controls.Add(this.DescriptionRichTextBox);
            this.Name = "ToDo";
            this.Size = new System.Drawing.Size(439, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.CheckedListBox TasksCheckedListBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label TasklistLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InWorkTxtBox;
    }
}
