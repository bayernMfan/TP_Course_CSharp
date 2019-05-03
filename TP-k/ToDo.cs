using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP_k
{
    public partial class ToDo : UserControl
    {

        ///имеет один собственный конструктор, а также конструктор без аргументов;
        public ToDo()
        {
            InitializeComponent();
            TaskSaved += TaskSavedHandler;
        }

        public ToDo(string color)
        {
            InitializeComponent();
            TaskSaved += TaskSavedHandler;
            this.BackColor = Color.Yellow;

        }

        //class of Tasks and information of them
        public class Task
        {
            public string ID { get; set; }//name

            public string RTFPath { get; set; }//description

            public DateTime TimeOfCreated { get; set; }

            public DateTime TimeTarget { get; set; }//picked time

            public Task() { }//empty constructor

            public Task(string inID, string inRTFPath, DateTime inTimeOfCreated, DateTime inTimeTarget)//full constructor
            {
                this.ID = inID;
                this.RTFPath = inRTFPath;
                this.TimeOfCreated = inTimeOfCreated;
                this.TimeTarget = inTimeTarget;
            }

            public Task(string inID, string inRTFPath)//saved tasks constructor
            {
                this.ID = inID;
                this.RTFPath = inRTFPath;
            }

        }


        ///имеет не менее двух собственных свойств различных типов, связанных с основной функциональностью элемента управления(причём при изменении
        ///хотя бы одного из них должно происходить немедленное изменение в элементе управления)

        //main Dictionary of User's Tasks
        public Dictionary<string, Task> Tasks = new Dictionary<string, Task>();

        //public Dictionary<string, Task> SavedTasks = new Dictionary<string, Task>();

        //двух вспомогательных свойств
        protected DateTime currentTime = DateTime.Now;
        string UsersRTFPath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\UsersRTF");

        ///а также трёх свойств, сопоставленных свойствам элементов управления, входящих в состав создаваемого элемента управления(Design);
        //TODO
        public Color ctrlBackColor = Color.Aqua;
        public void ChangeCtrlBackColor()
        {
            foreach (Control control in this.Controls)
                control.BackColor = ctrlBackColor;
        }
        public Color fontColor = Color.Black;
        public void ChangeFontColor()
        {
            foreach (Control control in this.Controls)
                control.ForeColor = fontColor;
        }

        ///имеет не менее двух новых публичных методов в совокупности с не менее чем тремя аргументами, в одном из случаев – в виде функции;

        public void LoadSavedTasks()
        {
            if (!Directory.Exists(UsersRTFPath))
                MessageBox.Show(UsersRTFPath + " not found");
            else
                foreach (string file in Directory.EnumerateFiles(UsersRTFPath, "*.rtf"))
                {
                    if (file.Count() == 0)
                        MessageBox.Show("No .rtf files found in " + UsersRTFPath);
                    else if (file.ToString().Split('\\').Last().StartsWith("Task_"))
                    {
                        string taskTmp = file.ToString().Split('\\').Last().Split('.').First();
                        if (!TasksCheckedListBox.Items.Contains(taskTmp))
                        {
                            TasksCheckedListBox.Items.Add(taskTmp);
                            Tasks[taskTmp] = new Task(taskTmp, file);
                        }
                        else
                            Tasks[taskTmp] = new Task(taskTmp, file);
                    }
                    //string contents = File.ReadAllText(file);
                }
        }
        //CreateRichTextFile(string function)
        public string CreateRTF(string fileName)
        {
            // Working directory 
            string fileNameWithExt = fileName + ".rtf";
            if (!Directory.Exists(UsersRTFPath))
                Directory.CreateDirectory(UsersRTFPath);//creating WorkingDir in first run
            string rtfFilePath = Path.Combine(UsersRTFPath, fileNameWithExt);
            MessageBox.Show(rtfFilePath);

            // Create a new file     
            using (FileStream fs = File.Create(rtfFilePath))
                return rtfFilePath;//and return its Path
        }

        //DeleteRichTextFile(void method)
        public void DeleteRTF(string rtfPath)
        {
            // Working directory 
            if (!Directory.Exists(UsersRTFPath))
                MessageBox.Show("directory UsersRTF does not exist at current directory");
            else
                if (!File.Exists(rtfPath))
                MessageBox.Show(rtfPath.Split('\\').Last() + " does not exist at " + UsersRTFPath);
            else
                File.Delete(rtfPath);
        }

        //getter to get access to protected CheckedListBox
        public CheckedListBox TasksCLB
        {
            get
            {
                return this.TasksCheckedListBox;
            }
        }

        //function calculating progress %
        public int ProgressCalc(float count, float done)
        {
            float percent = (done / count) * 100;
            return Convert.ToInt32(percent);
        }

        //function of counting Tasks by their TargetDate
        public int CountByDate(Dictionary<string, Task> TargetDictionary, string TimeTarget)
        {
            int count = 0;
            foreach (Task tmpTask in TargetDictionary.Values)
                if (tmpTask.TimeTarget.ToShortDateString() == TimeTarget)
                    count++;
            return count;
        }

        //имеет не менее двух новых событий, хотя бы в одном случае – с аргументом собственного класса;
        public delegate void F(String ID);
        public event F TaskSaved;
        private void TaskSavedHandler(String ID)
        {
            MessageBox.Show("Task with ID \"" + ID + "\" successfully saved!");
        }

        //использует один интерфейс (тип interface), включающий логически целостный фрагмент функциональности класса элемента управления.
        //TODO

        private void ButtonAdd_Click(object sender, EventArgs e)//add new task
        {
            try
            {
                if (TasksCheckedListBox.Items.Count == 0)
                {
                    TasksCheckedListBox.Items.Add("Task_1");
                }
                else
                {
                    TasksCheckedListBox.SetSelected(TasksCheckedListBox.Items.Count - 1, true);
                    string prevKey = TasksCheckedListBox.SelectedItem.ToString();
                    TasksCheckedListBox.SetSelected(TasksCheckedListBox.Items.Count - 1, false);
                    prevKey.ToArray();
                    TasksCheckedListBox.Items.Add("Task_" + (int.Parse(prevKey.Split('_').Last()) + 1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)//delete selected task
        {
            try
            {
                if (TasksCheckedListBox.SelectedIndex != -1)
                {
                    string key = TasksCheckedListBox.SelectedItem.ToString();
                    if (Tasks.ContainsKey(key))
                    {
                        DeleteRTF(Tasks[key].RTFPath);//delete rtf file
                        Tasks.Remove(key);//delete Task object
                        TasksCheckedListBox.Items.Remove(TasksCheckedListBox.SelectedItem);//delete Task from TasksList
                    }
                    else
                    {
                        //MessageBox.Show("Values with this key not found");
                        TasksCheckedListBox.Items.Remove(TasksCheckedListBox.SelectedItem);//delete empty Task from TasksList
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)//save selected task
        {
            try
            {
                if (TasksCheckedListBox.SelectedIndex != -1)
                {
                    currentTime = DateTime.Now;
                    string key = TasksCheckedListBox.SelectedItem.ToString();

                    if (!Tasks.ContainsKey(key))//if key not found
                    {
                        string tmpRTFPath = CreateRTF(key);//create new rtf file
                        DescriptionRichTextBox.AppendText("\n******\nSaved at: " + currentTime.ToShortDateString() +
                                                          "\nTarget date picked: " + dateTimePicker1.Value.ToShortDateString());//add date info
                        DescriptionRichTextBox.SaveFile(tmpRTFPath);//save content to created file
                        Tasks.Add(key, new Task(key, tmpRTFPath, currentTime, dateTimePicker1.Value));//create new Task object
                    }
                    else
                    {
                        DescriptionRichTextBox.AppendText("\n******\nSaved at: " + currentTime.ToShortDateString() +
                                                          "\nTarget date picked: " + dateTimePicker1.Value.ToShortDateString());
                        DescriptionRichTextBox.SaveFile(Tasks[key].RTFPath);//else save content to RTF file with correct key of Task object
                    }
                    TaskSaved(key);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TasksCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)//freroam tasks
        {
            try
            {
                if (TasksCheckedListBox.SelectedIndex != -1)
                {
                    string key = TasksCheckedListBox.SelectedItem.ToString();
                    switch (Tasks.ContainsKey(key))
                    {
                        case true:
                            DescriptionRichTextBox.LoadFile(Tasks[key].RTFPath, RichTextBoxStreamType.RichText);
                            //DescriptionRichTextBox.AppendText("\n******\nSaved at: " + Tasks[key].TimeOfCreated.ToShortDateString() +
                                                              //"\nTarget date picked: " + Tasks[key].TimeTarget.ToShortDateString());
                            break;
                        case false:
                            MessageBox.Show("Task didnt found in TasksList. \nTIP: try to load previously saved tasks");
                            //DescriptionRichTextBox.LoadFile(UsersRTFPath + @"\" + key + ".rtf", RichTextBoxStreamType.RichText
                            break;
                    }
                }
                else DescriptionRichTextBox.Clear();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                DescriptionRichTextBox.Clear();
                InWorkTxtBox.Text = (ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DescriptionRichTextBox.LoadFile(@"C:\Users\Andrey\Desktop\4 семестр\TP-k (exp)\TP-k\bin\Debug\UsersRTF\sample.rtf");
            LoadSavedTasks();
            ChangeCtrlBackColor();
            ChangeFontColor();
        }
    }
}
