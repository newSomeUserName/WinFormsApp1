namespace WinFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.teacher = new System.Windows.Forms.Button();
            this.teacherNameBox = new System.Windows.Forms.TextBox();
            this.teacherAge = new System.Windows.Forms.TextBox();
            this.avGrade = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.TextBox();
            this.b3 = new System.Windows.Forms.TextBox();
            this.b4 = new System.Windows.Forms.TextBox();
            this.b5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(9, 214);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(403, 224);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить преп.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(615, 354);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(173, 29);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 27);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // teacher
            // 
            this.teacher.Location = new System.Drawing.Point(9, 191);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(403, 29);
            this.teacher.TabIndex = 6;
            this.teacher.Text = "teacher";
            this.teacher.UseVisualStyleBackColor = true;
            this.teacher.Click += new System.EventHandler(this.teacher_Click);
            // 
            // teacherNameBox
            // 
            this.teacherNameBox.Location = new System.Drawing.Point(488, 26);
            this.teacherNameBox.Name = "teacherNameBox";
            this.teacherNameBox.Size = new System.Drawing.Size(300, 27);
            this.teacherNameBox.TabIndex = 7;
            this.teacherNameBox.TextChanged += new System.EventHandler(this.teacherNameBox_TextChanged);
            // 
            // teacherAge
            // 
            this.teacherAge.Location = new System.Drawing.Point(488, 59);
            this.teacherAge.Name = "teacherAge";
            this.teacherAge.Size = new System.Drawing.Size(125, 27);
            this.teacherAge.TabIndex = 8;
            this.teacherAge.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // avGrade
            // 
            this.avGrade.Location = new System.Drawing.Point(488, 101);
            this.avGrade.Name = "avGrade";
            this.avGrade.Size = new System.Drawing.Size(154, 27);
            this.avGrade.TabIndex = 9;
            this.avGrade.TextChanged += new System.EventHandler(this.avGrade_TextChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(615, 319);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(173, 29);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(488, 143);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(33, 27);
            this.b1.TabIndex = 11;
            this.b1.TextChanged += new System.EventHandler(this.b1_TextChanged);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(538, 143);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(33, 27);
            this.b2.TabIndex = 12;
            this.b2.TextChanged += new System.EventHandler(this.b2_TextChanged);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(591, 143);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(33, 27);
            this.b3.TabIndex = 13;
            this.b3.TextChanged += new System.EventHandler(this.b3_TextChanged);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(640, 143);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(33, 27);
            this.b4.TabIndex = 14;
            this.b4.TextChanged += new System.EventHandler(this.b4_TextChanged);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(691, 143);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(33, 27);
            this.b5.TabIndex = 15;
            this.b5.TextChanged += new System.EventHandler(this.b5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.avGrade);
            this.Controls.Add(this.teacherAge);
            this.Controls.Add(this.teacherNameBox);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox2;
        private Button buttonAdd;
        private TextBox textBox3;
        private Button teacher;
        private TextBox teacherNameBox;
        private TextBox teacherAge;
        private TextBox avGrade;
        private Button backButton;
        private TextBox b1;
        private TextBox b2;
        private TextBox b3;
        private TextBox b4;
        private TextBox b5;
    }
}