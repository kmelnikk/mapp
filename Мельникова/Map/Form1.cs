using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            panel1.Visible = false;
            labeltop.Visible = false;
            labeldrink.Visible = false;
            pictureDrink.Visible = false;
            pictureEnergy.Visible = false;
            pictureInformation.Visible = false;
            pictureMedical.Visible = false;
            pictureToilet.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Финиш";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = false;
            labelenergy.Visible = false;
            labelinf.Visible = false;
            labelmedicine.Visible = false;
            labeltoilet.Visible = false;
            pictureDrink.Visible = false;
            pictureEnergy.Visible = false;
            pictureInformation.Visible = false;
            pictureMedical.Visible = false;
            pictureToilet.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            labeltop.Visible = true;
            labeltop.Text = "МЦК Лужники";
            labeldrink.Text = "Питьевые напитки";
            labelenergy.Text = "Энергетические батончики";
            pictureDrink.Visible = true;
            pictureEnergy.Visible = true;
            labeldrink.Visible = true;
            labelenergy.Visible = true;
            labelinf.Visible = false;
            labelmedicine.Visible = false;
            labeltoilet.Visible = false;
            pictureInformation.Visible = false;
            pictureMedical.Visible = false;
            pictureToilet.Visible = false;
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Новодевичей Монастырь";
            labeldrink.Text = "Питьевые напитки";
            labelenergy.Text = "Энергетические батончики";
            labelinf.Text = "Стенд информации";
            labelmedicine.Text = "Мед пункт";
            labeltoilet.Text = "Туалет";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = true;
            labelenergy.Visible = true;
            labelinf.Visible = true;
            labelmedicine.Visible = true;
            labeltoilet.Visible = true;
            pictureDrink.Visible = true;
            pictureEnergy.Visible = true;
            pictureInformation.Visible = true;
            pictureMedical.Visible = true;
            pictureToilet.Visible = true;
           
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Метро Киевская";
            labeldrink.Text = "Питьевые напитки";
            labelenergy.Text = "Энергетические батончики";
            labelinf.Text = "Стенд информации";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = true;
            labelenergy.Visible = true;
            labelinf.Visible = true;
            labelmedicine.Visible = false;
            labeltoilet.Visible = false;
            pictureDrink.Visible = true;
            pictureEnergy.Visible = true;
            pictureInformation.Visible = true;
            pictureMedical.Visible = false;
            pictureToilet.Visible = false;
          

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            labeltop.Text = "МИД";
            labeldrink.Text = "Питьевые напитки";
            labelenergy.Text = "Энергетические батончики";
            labelinf.Text = "Стенд информации";
            labelmedicine.Text = "Мед пункт";
            labeltoilet.Text = "Туалет";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = true;
            labelenergy.Visible = true;
            labelinf.Visible = true;
            labelmedicine.Visible = false;
            labeltoilet.Visible = true;
            pictureDrink.Visible = true;
            pictureEnergy.Visible = true;
            pictureInformation.Visible = true;
            pictureMedical.Visible = false;
            pictureToilet.Visible = true;
           
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Парк Горького";
            labeldrink.Text = "Питьевые напитки";
            labelenergy.Text = "Энергетические батончики";
            labelinf.Text = "Стенд информации";
            labelmedicine.Text = "Мед пункт";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = true;
            labelenergy.Visible = true;
            labelinf.Visible = true;
            labelmedicine.Visible = true;
            labeltoilet.Visible = false;
            pictureDrink.Visible = true;
            pictureEnergy.Visible = true;
            pictureInformation.Visible = true;
            pictureMedical.Visible = true;
            pictureToilet.Visible = false;
           
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Метро Воробьёвы Горы";
            labeldrink.Text = "Питьевые напитки";
            labelenergy.Text = "Энергетические батончики";
            labelinf.Text = "Стенд информации";
            labelmedicine.Text = "Мед пункт";
            labeltoilet.Text = "Туалет";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = true;
            labelenergy.Visible = true;
            labelinf.Visible = true;
            labelmedicine.Visible = true;
            labeltoilet.Visible = true;
            pictureDrink.Visible = true;
            pictureEnergy.Visible = true;
            pictureInformation.Visible = true;
            pictureMedical.Visible = true;
            pictureToilet.Visible = true;
           
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Стадион лужники";
            labeldrink.Text = "Питьевые напитки";
            labelenergy.Text = "Энергетические батончики";
            labelinf.Text = "Стенд информации";
            labelmedicine.Text = "Мед пункт";
            labeltoilet.Text = "Туалет";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = true;
            labelenergy.Visible = true;
            labelinf.Visible = true;
            labelmedicine.Visible = true;
            labeltoilet.Visible = true;
            pictureDrink.Visible = true;
            pictureEnergy.Visible = true;
            pictureInformation.Visible = true;
            pictureMedical.Visible = true;
            pictureToilet.Visible = true;
            
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Здание РАН";
            labeldrink.Text = "Питьевые напитки";
            labelenergy.Text = "Энергетические батончики";
            labelinf.Text = "Стенд информации";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = true;
            labelenergy.Visible = true;
            labelinf.Visible = true;
            labelmedicine.Visible = false;
            labeltoilet.Visible = false;
            pictureDrink.Visible = true;
            pictureEnergy.Visible = true;
            pictureInformation.Visible = true;
            pictureMedical.Visible = false;
            pictureToilet.Visible = false;
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Старт \n Трасса Марафон Самба";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = false;
            labelenergy.Visible = false;
            labelinf.Visible = false;
            labelmedicine.Visible = false;
            labeltoilet.Visible = false;
            pictureDrink.Visible = false;
            pictureEnergy.Visible = false;
            pictureInformation.Visible = false;
            pictureMedical.Visible = false;
            pictureToilet.Visible = false;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Старт \nТрасса Веселые гонки по капоэйра: 5  км";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = false;
            labelenergy.Visible = false;
            labelinf.Visible = false;
            labelmedicine.Visible = false;
            labeltoilet.Visible = false;
            pictureDrink.Visible = false;
            pictureEnergy.Visible = false;
            pictureInformation.Visible = false;
            pictureMedical.Visible = false;
            pictureToilet.Visible = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            labeltop.Text = "Старт \nТрасса Марафон по Джонго";
            panel1.Visible = true;
            labeltop.Visible = true;
            labeldrink.Visible = false;
            labelenergy.Visible = false;
            labelinf.Visible = false;
            labelmedicine.Visible = false;
            labeltoilet.Visible = false;
            pictureDrink.Visible = false;
            pictureEnergy.Visible = false;
            pictureInformation.Visible = false;
            pictureMedical.Visible = false;
            pictureToilet.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
