using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comparing_words
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
            string str;
            str = textbox.Text;
            char[] arr;
            arr = str.ToCharArray();
            var lengt = arr.Length;

            char symbol = arr[1];

            bool check = true;

            for (int i = 1; i < lengt; i += 2)
            {
                if (arr[i] != symbol)
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                MessageBox.Show
                ("Буквы совпадают",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Слово не прошло прверку", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textbox.Clear();
            
        }
    }
}
