
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TeacherLib;
using TeacherLib.EventHandlers;
using WinFormsApp1.Storage;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            textBox2.Visible = false;
            textBox3.Visible = false;
            buttonAdd.Visible = false;
            teacherNameBox.Visible = false;
            teacherAge.Visible= false;
            avGrade.Visible = false;
            backButton.Visible = false;


            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
            b5.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            listBox1_SelectedIndexChanged(sender, e);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            if (textBox1.Text.Length < 1)
            {
                return;
            }

            FileInfo[] fs  = new DirectoryInfo(@"C:\Users\gleb2\source\repos\WinFormsApp1\Application\bin\Debug\net7.0\Teachers").GetFiles();
            
            foreach (FileInfo item in fs)
            {
                string name = item.Name;
                if (name.StartsWith(textBox1.Text))
                {
                    listBox1.Items.Add(name);
                }
                

            }

            if (listBox1.Items.Count != 0)
            {
                listBox1.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            teacher.Visible = false;

            textBox2.Visible = true;
            textBox3.Visible = true;
            buttonAdd.Visible = true;




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;
            if (textBox2.Text == string.Empty || textBox3.Text == string.Empty)
                return;
            TeachersCharacteristics teachersCharacteristics = new TeachersCharacteristics($"{textBox2.Text}", Convert.ToInt32(textBox3.Text), GetAlernt);
            string path = $@"C:\Users\gleb2\source\repos\WinFormsApp1\Application\bin\Debug\net7.0\Teachers\{textBox2.Text}.txt";

            using (FileCreator fc = new FileCreator(path, teachersCharacteristics))
            {

            }
            listBox1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            teacher.Visible = true;

            textBox2.Visible = false;
            textBox3.Visible = false;
            buttonAdd.Visible = false;

        }
        static void GetAlernt(object sender, EventArgs e)
        {
            GradeEventHandler handler = (GradeEventHandler)e;
            Console.WriteLine(handler.Message);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacher_Click(object sender, EventArgs e)
        {
            teacherNameBox.Visible = true;
            teacherAge.Visible = true;
            avGrade.Visible = true;
            b1.Visible = true;
            b2.Visible = true;
            b3.Visible = true;
            b4.Visible = true;
            b5.Visible = true;
            string path = $@"C:\Users\gleb2\source\repos\WinFormsApp1\Application\bin\Debug\net7.0\Teachers\{listBox1.Items[0].ToString()}";
            using (FileCreator fc = new FileCreator(path, null))
            {
                TeachersCharacteristics t = fc.ReadInfo();
                teacherNameBox.Text = t.FullName;
                teacherAge.Text = Convert.ToString(t.Qualification);
                avGrade.Text = Convert.ToString(t.AverageGrade);

                b1.Text = t.Grade.FindAll((x) => x == 5.0).Count.ToString();
                b2.Text = t.Grade.FindAll((x) => x == 4.0).Count.ToString();
                b3.Text = t.Grade.FindAll((x) => x == 3.0).Count.ToString();
                b4.Text = t.Grade.FindAll((x) => x == 2.0).Count.ToString();
                b5.Text = t.Grade.FindAll((x) => x == 1.0).Count.ToString();
            }
        }

        private void teacherNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void avGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            teacher.Visible = true;

            textBox2.Visible = false;
            textBox3.Visible = false;
            buttonAdd.Visible = false;
            avGrade.Visible = false;
            backButton.Visible = false;
        }

        private void b1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b2_TextChanged(object sender, EventArgs e)
        {

        }

        private void b3_TextChanged(object sender, EventArgs e)
        {

        }

        private void b4_TextChanged(object sender, EventArgs e)
        {

        }

        private void b5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}