using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace pasword_genaratore
{
    public partial class reader : Form
    {
        public reader()
        {
            InitializeComponent();
        }


        private void make_paswords_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
        }

        private void button1__Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            if (textBox2.Text != "pasword's name?" && File.Exists("E:" + name + ".pasword"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                string path = @"E:" + name + ".pasword";
                FileStream fs = new FileStream(path, FileMode.Open);
                data.data_for_saving data_ = bf.Deserialize(fs) as data.data_for_saving;
                textBox1.Text = data_.pasword;
                fs.Close();
            }
            else
            {
                textBox2.Text = "wrong name,didnt find a pasword with that name";
                textBox2.ForeColor = Color.Red;
            }
        }
    }
}
