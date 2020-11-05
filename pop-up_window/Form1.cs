using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pop_up_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст сообщения", "Заголовок сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult res =  MessageBox.Show("Текст сообщения", "Заголовок сообщения", MessageBoxButtons.YesNo);

            if (res==DialogResult.Yes)
            {
                MessageBox.Show("Была нажата кнопка\"ДА\"", "", MessageBoxButtons.OK);
            }
            else if(res == DialogResult.No)
            {
                MessageBox.Show("Была нажата кнопка\"НЕТ\"", "", MessageBoxButtons.OK);
            }
        }
    }
}
