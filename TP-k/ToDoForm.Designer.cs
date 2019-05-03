namespace TP_k
{
    partial class ToDoForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ButtonRestore = new System.Windows.Forms.Button();
            this.LabelProgression = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Theme_btn = new System.Windows.Forms.Button();
            this.ThemeListBox = new System.Windows.Forms.ListBox();
            this.toDo_object = new TP_k.ToDo();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(422, 42);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(230, 23);
            this.ProgressBar.TabIndex = 14;
            // 
            // ButtonRestore
            // 
            this.ButtonRestore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRestore.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonRestore.Location = new System.Drawing.Point(422, 71);
            this.ButtonRestore.Name = "ButtonRestore";
            this.ButtonRestore.Size = new System.Drawing.Size(75, 23);
            this.ButtonRestore.TabIndex = 13;
            this.ButtonRestore.Text = "Restore";
            this.ButtonRestore.UseVisualStyleBackColor = false;
            this.ButtonRestore.Click += new System.EventHandler(this.ButtonRestore_Click);
            // 
            // LabelProgression
            // 
            this.LabelProgression.AutoSize = true;
            this.LabelProgression.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LabelProgression.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LabelProgression.Location = new System.Drawing.Point(422, 22);
            this.LabelProgression.Name = "LabelProgression";
            this.LabelProgression.Size = new System.Drawing.Size(62, 13);
            this.LabelProgression.TabIndex = 12;
            this.LabelProgression.Text = "Progression";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(425, 100);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Date";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(484, 226);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // Theme_btn
            // 
            this.Theme_btn.Location = new System.Drawing.Point(686, 42);
            this.Theme_btn.Name = "Theme_btn";
            this.Theme_btn.Size = new System.Drawing.Size(223, 23);
            this.Theme_btn.TabIndex = 16;
            this.Theme_btn.Text = "New Yellow ToDo\r\n";
            this.Theme_btn.UseVisualStyleBackColor = true;
            this.Theme_btn.Click += new System.EventHandler(this.Theme_btn_Click);
            // 
            // ThemeListBox
            // 
            this.ThemeListBox.FormattingEnabled = true;
            this.ThemeListBox.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "Carnaval"});
            this.ThemeListBox.Location = new System.Drawing.Point(789, 332);
            this.ThemeListBox.Name = "ThemeListBox";
            this.ThemeListBox.Size = new System.Drawing.Size(120, 43);
            this.ThemeListBox.TabIndex = 17;
            // 
            // toDo_object
            // 
            this.toDo_object.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toDo_object.Location = new System.Drawing.Point(13, 12);
            this.toDo_object.Name = "toDo_object";
            this.toDo_object.Size = new System.Drawing.Size(406, 350);
            this.toDo_object.TabIndex = 18;
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(936, 488);
            this.Controls.Add(this.toDo_object);
            this.Controls.Add(this.ThemeListBox);
            this.Controls.Add(this.Theme_btn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ButtonRestore);
            this.Controls.Add(this.LabelProgression);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ToDoForm";
            this.Text = "ToDo";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button ButtonRestore;
        private System.Windows.Forms.Label LabelProgression;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Theme_btn;
        private System.Windows.Forms.ListBox ThemeListBox;
        private ToDo toDo_object;
    }
}

