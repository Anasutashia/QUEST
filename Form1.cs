using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace QUEST
{
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
            button3.Hide();
            label1.Hide();
            label1.Parent = pictureBox1; //картинка родительский элемент что бы сделать фон прозрачным
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Show();
            label1.Show();
            label1.Text = "Всё просто идеально";
            pictureBox1.Image = Properties.Resources.sc001_dialog;


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            switch (a)
            {

                case 0:

                    pictureBox1.Image = Properties.Resources.sc002_dialog;
                    label1.Text = "Хозяйка, Ваш кофе готов. \n Ваша матушка ожидает Вас1.";
                    break;

                case 1:

                    pictureBox1.Image = Properties.Resources.sc003_dialog;
                    label1.ForeColor = Color.MistyRose; //меняет цвет текста
                    label1.Text = "Анна, доченька, я так рада тебя. \n видеть! А где мои внуки?";
                    break;

                   
            }

            a++;
        }

    }
}
