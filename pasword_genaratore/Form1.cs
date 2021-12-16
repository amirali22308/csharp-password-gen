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
    public partial class Form1 : Form
    {
        private bool checked_ = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void genareate_Click(object sender, EventArgs e)
        {

            bool isNumeric_b = int.TryParse(b_letters.Text, out _);
            bool isNumeric_n = int.TryParse(num.Text, out _);
            bool isNumeric_l = int.TryParse(lenthg_checker.Text, out _);
            int l_ = 4;
            int n_ = 0;
            int b_ = 0;
            if (isNumeric_l)
                l_ = Convert.ToInt32(lenthg_checker.Text);
            if (isNumeric_n)
                n_ = Convert.ToInt32(num.Text);
            if (isNumeric_b)
                b_ = Convert.ToInt32(b_letters.Text);
            List<string> pasword_ = genarate(l_,b_,n_);
            if (pasword_ == null)
            {
                textBox1.Text = "some thingis wrong, try again.";
            }
            else
            {
                textBox1.Text = "";
                foreach (string key_word in pasword_)
                {
                    textBox1.Text += key_word;
                }
                if (checked_)
                {
                    save(textBox1.Text,textBox2.Text);
                }
                
            }
        }
        private void save(string pasword,string name)
        {
            data.data_for_saving data_ = new data.data_for_saving();
            data_.name_for_pasword = name;
            data_.pasword = pasword;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists("E:" + name + ".pasword"))
            {
                name += "1";
            }
            string path = @"E:" + name + ".pasword";
            FileStream fs = new FileStream(path,FileMode.Create);
            bf.Serialize(fs, data_);
            fs.Close();
        }
        private List<string> genarate(int lenght, int how_many_big_letters, int how_many_numbers)
        {
            if (lenght < 4) { lenght = 4; }
            Random rnd = new Random();
            string[] big_ltters_ = new string[] { "A", "B", "C", "D", "E", "F", "G" };
            string[] small_ltters = new string[] { "a", "b", "c", "d", "e", "f", "g" };
            List<string> charectors = new List<string>();
            List<int> place = new List<int>();
            //the num and big charectors should not be more than lenght,this make sure of that
            if ((how_many_big_letters + how_many_numbers) > lenght)
                return null;
            //for setting up the place list
            for (int i = 0; i < lenght; i++)
                place.Add(i);
            //finding a rondom place foreach big charector
            for (int ii = 0; ii < how_many_big_letters; ii++)
            {
                bool done = false;
                while (!done)
                {
                    int palce_ = rnd.Next(0, lenght);
                    if (place[palce_] != -1 && place[palce_] != -2)
                    {
                        done = true;
                        place[palce_] = -1;
                    }
                }
            }
            //finding a rondom place foreach number charector
            for (int iii = 0; iii < how_many_numbers; iii++)
            {
                bool done = false;
                while (!done)
                {
                    int palce_ = rnd.Next(0, lenght);
                    if (place[palce_] != -1 && place[palce_] != -2)
                    {
                        done = true;
                        place[palce_] = -2;
                    }
                }
            }
            //for placing the charectors in the charectors list
            for (int iiii = 0; iiii < lenght; iiii++)
            {
                if (place[iiii] == -1) { charectors.Add(big_ltters_[rnd.Next(0, 6)]); }
                else if (place[iiii] == -2) { charectors.Add(Convert.ToString(rnd.Next(0, 9))); }
                else { charectors.Add(small_ltters[rnd.Next(0, 6)]); }
            }
            return charectors;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checked_)
                checked_ = false;
            else
                checked_ = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reader reader_ = new reader();
            reader_.Show();
        }

        private void b_letters_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lenthg_checker_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
namespace data
{
    [Serializable]
    public class data_for_saving
    {
        public string pasword;
        public string name_for_pasword;
    }
}