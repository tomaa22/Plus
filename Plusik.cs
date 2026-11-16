using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plus
{
    public partial class Plusik : Form
    {
        Random rnd = new Random();
        int random = 15;
        int PlayerStep = 0;
        int PlayerNumber = 1;
        public Plusik()
        {
            InitializeComponent();
            random = rnd.Next(1, 100);
            labelRND.Text = random.ToString();
            label1.Text = PlayerNumber.ToString();
            labelSteps.Text = "количество шагов: " + PlayerStep.ToString();
        }
        int Optimum(int k)
        {
            int CountStep = 0;
            while (k != 1)
            {
                if (k % 2 == 0)
                {
                    k /= 2;
                }
                else
                {
                    k -= 1;
                }
                CountStep++;
            }
            return CountStep;
        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            PlayerNumber += 1;
            PlayerStep += 1;
            label1.Text = PlayerNumber.ToString();
            labelSteps.Text = "Количество шагов: " + PlayerStep.ToString();

            if (PlayerNumber == random)
            {
                if (PlayerStep == Optimum(random))
                {
                    MessageBox.Show("вы выиграли.");
                }
                else
                {
                    MessageBox.Show("вы выиграли, но можно было лучше.");
                }
            }
            else if (PlayerNumber > random)
            {
                MessageBox.Show("вы проиграли, попробуйте еще раз.");
            }
        }

        private void pictureBoxMinus_Click(object sender, EventArgs e)
        {
            PlayerNumber *= 2;
            PlayerStep += 1;
            label1.Text = PlayerNumber.ToString();
            labelSteps.Text = "Количество шагов: " + PlayerStep.ToString();

            if (PlayerNumber == random)
            {
                if (PlayerStep == Optimum(random))
                {
                    MessageBox.Show("вы выиграли.");
                }
                else
                {
                    MessageBox.Show("вы выиграли, но можно было лучше.");
                }
            }
            else if (PlayerNumber > random)
            {
                MessageBox.Show("вы проиграли, попробуйте еще раз.");
            }
        }

        private void labelRND_Click(object sender, EventArgs e)
        {

        }

        private void labelReset_Click(object sender, EventArgs e)
        {
            PlayerNumber = 1;
            label1.Text = PlayerNumber.ToString();
            PlayerStep = 0;
            labelSteps.Text = "Количество шагов: " + PlayerStep.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetNum_Click(object sender, EventArgs e)
        {
            random = rnd.Next(1, 100);
            Optimum(random);
            labelRND.Text = random.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
