using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_k
{
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();
        }

        private void ButtonRestore_Click(object sender, EventArgs e)
        {
            int percent = toDo_object.ProgressCalc(toDo_object.TasksCLB.Items.Count, toDo_object.TasksCLB.CheckedItems.Count);
            MessageBox.Show(percent.ToString());
            ProgressBar.Value = percent;
            //MessageBox.Show(ProgressBar.Value.ToString());
            int count = toDo_object.CountByDate(toDo_object.Tasks, "27.04.2019");
            MessageBox.Show(count.ToString());
            //this.chart1.Series["Date"].Points.AddXY(DateTime.Now.ToShortDateString(), 1);
            //this.chart1.Series["Date"].Points.AddXY(DateTime.Now.AddDays(1).ToShortDateString(), 1);
            //this.chart1.Series["Date"].Points.AddXY(DateTime.Now.AddDays(2).ToShortDateString(), 5);
        }

        private void Theme_btn_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(toDo_object);
            toDo_object = new ToDo("color");
            this.Controls.Add(toDo_object);
        }
    }
}
