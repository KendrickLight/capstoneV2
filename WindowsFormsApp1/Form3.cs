using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            double width;
            double length;

            double.TryParse(textBox_width.Text, out width);
            double.TryParse(textBox_length.Text, out length);

            textBox_results.Text = (width * length).ToString();
        }

        private void TextBox_width_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_nextRoom_Click(object sender, EventArgs e)
        {
            bool text1IsFull=false;


            if (!text1IsFull)
            {
                textBox_room1SqFt.Text = textBox_results.Text;
                textBox_length.Clear();
                textBox_width.Clear();
                textBox_results.Clear();
                text1IsFull = true;
            }




        }

        private void Button_room2Next_Click(object sender, EventArgs e)
        {
            bool text2IsFull = false;


            if (!text2IsFull)
            {
                textBox_room2SqFt.Text = textBox_results.Text;
                textBox_length.Clear();
                textBox_width.Clear();
                textBox_results.Clear();
                text2IsFull = true;
            }




        }

        private void Button_room3Next_Click(object sender, EventArgs e)
        {
            bool text3IsFull = false;


            if (!text3IsFull)
            {
                textBox_room3SqFt.Text = textBox_results.Text;
                textBox_length.Clear();
                textBox_width.Clear();
                textBox_results.Clear();
                text3IsFull = true;
            }
        }

        private void Button_room4Next_Click(object sender, EventArgs e)
        {
            bool text4IsFull = false;


            if (!text4IsFull)
            {
                textBox_room4SqFt.Text = textBox_results.Text;
                textBox_length.Clear();
                textBox_width.Clear();
                textBox_results.Clear();
                text4IsFull = true;
            }
        }

        private void Textbox_totalSqFt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_done_Click(object sender, EventArgs e)
        {
            double room1;
            double room2;
            double room3;
            double room4;

            double.TryParse(textBox_room4SqFt.Text, out room4);
            double.TryParse(textBox_room3SqFt.Text, out room3);
            double.TryParse(textBox_room2SqFt.Text, out room2);
            double.TryParse(textBox_room1SqFt.Text, out room1);
            textbox_totalSqFt.Text = (room1 + room2 + room3 + room4).ToString();
        }
    }
}

