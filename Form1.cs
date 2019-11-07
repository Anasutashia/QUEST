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
            label2.Hide();
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;//картинка родительский элемент что бы сделать фон прозрачным
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

                case 4:

                    pictureBox1.Image = Properties.Resources.sc003_dialog;
                    label1.ForeColor = Color.Aqua; //меняет цвет 
                    label1.Text = "Анна \n Если бы не эти роботы, Вы бы не ездели \n  по заграницам, мама.";
                    break;
                case 5:

                    pictureBox1.Image = Properties.Resources.sc004_dialog;
                    label1.Hide();
                    label2.Show();
                    label2.ForeColor = Color.Aqua; //меняет цвет 
                    label2.Text = "Анна \n Да, если бы не эти роботы... \n  Если бы ни одна глупая идея, поразившая \n меня когда-то... Мир бы не изменился...\n 10 лет назад, я не выдержала работать по \n 14 часов в день за копейки и ушла\n из подручных материалов \n собрала 3д принтер какое то  \nвремя ушло на доработку, что бы \n он печатал пластиковыми бутылками";
                    break;
                case 6:

                    pictureBox1.Image = Properties.Resources.sc004_dialog;
                    label1.Hide();
                    label2.Show();
                    label2.ForeColor = Color.Aqua; //меняет цвет 
                    label2.Text = "Анна \n Далее несколько двигателей, \n микроконтроллер, элементы питания \n часы программирования и получился\n первый протитоп, а далее я выложила код \n во всемирную паутину \n что бы люди могли себе сами \n собрать роботов, но \n но на удивление со мной \nсвязались несколько компаний ";
                    break;
                case 7:

                    pictureBox1.Image = Properties.Resources.sc004_dialog;
                    label1.Hide();
                    label2.Show();
                    label2.ForeColor = Color.Aqua; //меняет цвет 
                    label2.Text = "Анна \n Прошло меньше недели, а у меня  \n уже появилось много денег \n роботы стали внедряться повсеместно\n магазины, производство, фирмы \n как следствие, 90% обслуживающего \n персонала потеряло работу \n некоторые меня даже за это \n уничтожить пытались \n глядя на это я открыла";
                    break;
                case 8:

                    pictureBox1.Image = Properties.Resources.sc004_dialog;
                    label1.Hide();
                    label2.Show();
                    label2.ForeColor = Color.Aqua; //меняет цвет 
                    label2.Text = "Анна \n Несколько фирм, фондов, \n по переквалификации людей\n каждому задавалось 2 вопроса :\n 1) Кем Вы мечтали быть в детстве? \n 2) Кем Вы мечтаете быть сейчас? \n далее фирма берёт  на себя все расходы \n и помогает людям с переобучением \n чеез пару лет эта система дала свои\n плоды ";
                    break;
                case 9:

                    pictureBox1.Image = Properties.Resources.sc004_dialog;
                    label1.Hide();
                    label2.Show();
                    label2.ForeColor = Color.Aqua; //меняет цвет 
                    label2.Text = "Анна \n Человек, всю жизнь увлекавшийся \n химией и биологией смог распечатать\n на принтере кусок мяса, нужные микро\n элементы для которого синтезированы \n из земли и воды. Другой создал\n антигравитационный привод. Машины\n и поезда ездят не касаясь земли, \n что снизило количество смертей\n на железных и машинных дорогах. ";
                    break;
                case 10:

                    pictureBox1.Image = Properties.Resources.sc004_dialog;
                    label1.Hide();
                    label2.Show();
                    label2.ForeColor = Color.Aqua; //меняет цвет 
                    label2.Text = "Анна \n Каждый человек стал заниматься\nлюбимым делом и делать это  \nкачественно. Даже мусора не осталось.  \nПобедили страшные болезни, научились \n продлевать жизнь, снизилась преступность, \n стали более уважительно \n относится к животным. Править миром \n стал искуственный интелект без \n условно по началу не все были довольны.";
                    break;
            }

            a++;
        }

    }
}
