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
            label1.Text = "Анна \n Всё просто идеально!";
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
                    label1.ForeColor = Color.PaleGreen; //меняет цвет 
                    label1.Text = "РП47в3 \n Хозяйка, Ваш кофе готов. \n Ваша матушка ждёт Вас внизу.";
                    break;

                case 1:

                    pictureBox1.Image = Properties.Resources.sc003_dialog;
                    label1.ForeColor = Color.MistyRose; //меняет цвет 
                    label1.Text = "Матушка \n Анна, доченька, я так рада тебя. \n видеть! А где мои внуки?";
                    break;

                case 2:

                    pictureBox1.Image = Properties.Resources.sc003_dialog;
                    label1.ForeColor = Color.Aqua; //меняет цвет 
                    label1.Text = "Анна \n Готовятся завтракать. Как Ваш заграничный \n  отдых, мама?";
                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.sc003_dialog;
                    label1.ForeColor = Color.MistyRose; //меняет цвет 
                    label1.Text = "Матушка \n Как всегда восхитетельно! А ты снова \n  поручила воспитание своих детей роботам?";
                    break;

            }

            a++;
        }

    }
}
