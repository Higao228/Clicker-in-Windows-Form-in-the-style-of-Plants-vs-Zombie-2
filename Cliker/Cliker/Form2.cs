using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Cliker
{
    public partial class Form2 : Form
    {
        public int money = 0;
        public int multi = 1;
        public int upgradecost1 = 20;
        public int upgradescount1 = 0;
        public int upgradecost2 = 40;
        public int upgradescount2 = 0;
        public int upgradecost3 = 60;
        public int upgradescount3 = 0;
        public int upgradecost4 = 80;
        public int upgradescount4 = 0;
        public int upgradecost5 = 100;
        public int upgradescount5 = 0;
        public int next = 2500;
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            money = money + multi;
            label1.Text = $"Money: {money}$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money > upgradecost1 - 1)
            {
                money = money - upgradecost1;
                label1.Text = $"Money: {money}$";
                upgradescount1++;
                label2.Text = $"Upgrades Count: {upgradescount1}";
                upgradecost1 = upgradecost1 * 2;
                label4.Text = $"Upgrade Cost: {upgradecost1}$";
                multi++;
                label3.Text = $"Money Per Click: {multi}$";
            }
            else
            {
                MessageBox.Show("Денег нет", "Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (money > upgradecost2 - 1)
            {
                money = money - upgradecost2;
                label1.Text = $"Money: {money}$";
                upgradescount2++;
                label7.Text = $"Upgrades Count: {upgradescount2}";
                upgradecost2 = upgradecost2 * 2;
                label6.Text = $"Upgrade Cost: {upgradecost2}$";
                multi++;
                label6.Text = $"Upgrade Cost: {upgradecost2}$";
                multi++;
                label3.Text = $"Money Per Click: {multi}$";
            }
            else
            {
                MessageBox.Show("Денег нет", "Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (money > upgradecost3 - 1)
            {
                money = money - upgradecost3;
                label1.Text = $"Money: {money}$";
                upgradescount3++;
                label13.Text = $"Upgrades Count: {upgradescount3}";
                upgradecost3 = upgradecost3 * 2;
                label10.Text = $"Upgrade Cost: {upgradecost3}$";
                multi++;
                label10.Text = $"Upgrade Cost: {upgradecost3}$";
                multi++;
                label10.Text = $"Upgrade Cost: {upgradecost3}$";
                multi++;
                label3.Text = $"Money Per Click: {multi}$";
            }
            else
            {
                MessageBox.Show("Денег нет", "Ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (money > upgradecost4 - 1)
            {
                money = money - upgradecost4;
                label1.Text = $"Money: {money}$";
                upgradescount4++;
                label12.Text = $"Upgrades Count: {upgradescount4}";
                upgradecost4 = upgradecost4 * 2;
                label9.Text = $"Upgrade Cost: {upgradecost4}$";
                multi++;
                label9.Text = $"Upgrade Cost: {upgradecost4}$";
                multi++;
                label9.Text = $"Upgrade Cost: {upgradecost4}$";
                multi++;
                label9.Text = $"Upgrade Cost: {upgradecost4}$";
                multi++;
                label3.Text = $"Money Per Click: {multi}$";
            }
            else
            {
                MessageBox.Show("Денег нет", "Ошибка");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (money > upgradecost5 - 1)
            {
                money = money - upgradecost5;
                label1.Text = $"Money: {money}$";
                upgradescount5++;
                label11.Text = $"Upgrades Count: {upgradescount5}";
                upgradecost5 = upgradecost5 * 2;
                label8.Text = $"Upgrade Cost: {upgradecost5}$";
                multi++;
                label8.Text = $"Upgrade Cost: {upgradecost5}$";
                multi++;
                label8.Text = $"Upgrade Cost: {upgradecost5}$";
                multi++;
                label8.Text = $"Upgrade Cost: {upgradecost5}$";
                multi++;
                label8.Text = $"Upgrade Cost: {upgradecost5}$";
                multi++;
                label3.Text = $"Money Per Click: {multi}$";
            }
            else
            {
                MessageBox.Show("Денег нет", "Ошибка");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (money > next - 1)
            {

                Form3 newForm = new Form3();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Денег нет", "Ошибка");
            }
        }
    }
}
