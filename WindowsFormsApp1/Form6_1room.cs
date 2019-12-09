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
    public partial class Form6_1room : Form
    {
        public Form6_1room()
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
            bool text1IsFull = false;


            if (!text1IsFull)
            {
                textBox_room1SqFt.Text = textBox_results.Text;
                textBox_length.Clear();
                textBox_width.Clear();
                textBox_results.Clear();
                text1IsFull = true;
            }




        }


        private void Textbox_totalSqFt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_done_Click(object sender, EventArgs e)
        {
            double room1;


            double.TryParse(textBox_room1SqFt.Text, out room1);
            textbox_totalSqFt.Text = (room1).ToString();
        }

    }
}
