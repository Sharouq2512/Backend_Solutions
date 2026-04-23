using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project01
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        // ➕ ADD STUDENT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                string name = textBox2.Text;

                if (students.Exists(x => x.Id == id))
                {
                    MessageBox.Show("Student already exists!");
                    return;
                }

                students.Add(new Student { Id = id, Name = name });

                RefreshList();
            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }
        }

        // ❌ REMOVE STUDENT (FIXED)
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);

                int removed = students.RemoveAll(x => x.Id == id);

                if (removed > 0)
                    MessageBox.Show("Student removed!");
                else
                    MessageBox.Show("Student not found!");

                RefreshList();
            }
            catch
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        // 🔍 SEARCH STUDENT (FIXED)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);

                Student s = students.Find(x => x.Id == id);

                if (s != null)
                    MessageBox.Show("Found: " + s.Name);
                else
                    MessageBox.Show("Student not found!");
            }
            catch
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        // 📋 REFRESH LIST
        private void RefreshList()
        {
            listBox1.Items.Clear();

            foreach (Student s in students)
            {
                listBox1.Items.Add(s);
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);

                int removed = students.RemoveAll(x => x.Id == id);

                if (removed > 0)
                    MessageBox.Show("Student removed!");
                else
                    MessageBox.Show("Student not found!");

                RefreshList();
            }
            catch
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);

                Student s = students.Find(x => x.Id == id);

                if (s != null)
                    MessageBox.Show("Found: " + s.Name);
                else
                    MessageBox.Show("Student not found!");
            }
            catch
            {
                MessageBox.Show("Invalid ID!");
            }
        }
    }

    // STUDENT CLASS
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Id + " - " + Name;
        }
    }
}