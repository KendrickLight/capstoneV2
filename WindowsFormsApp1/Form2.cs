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
    public partial class Form2: Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }


        private void Button_toForm3_Click(object sender, EventArgs e)
        {
            string numberOfRooms = textBox_howMenyRooms.Text;
            
            
            //switch (numberOfRooms)
            //{
            //    case "1":
            //        //Form3_4rooms.Close();
            //        //Form4_3rooms.Close();
            //        //Form5_2rooms.Close();
            //        Application.Run(new Form6_1room());
            //        break;
            //    case"2":
            //        Application.Run(new Form5_2rooms());
            //        break;
            //    case"3":
            //        Application.Run(new Form4_3rooms());
            //        break;
            //    case"4":
            //        Application.Run(new Form3_4rooms());
            //        break;
            //    default:
            //        break;
            //}
            Close();
            
        }

        private void TextBox_howMenyRooms_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
