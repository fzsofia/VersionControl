using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource1.FullName; 
            
            button1.Text = Resource1.Add;

            label1.Text = Resource1.FullName;
            
            button1.Text = Resource1.Add;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";

            var x = new User()
            {
                FullName = textBox1.Text
                
            };
            users.Add(x);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() != DialogResult.OK) return;

            StreamWriter sw = new StreamWriter(@"C:\Users\zsofi\Desktop\nev.txt");


        }

    }
}
