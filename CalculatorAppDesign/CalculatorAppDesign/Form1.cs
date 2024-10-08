﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float data1, data2;
        string pheptinh;
        bool isResultDisplayed = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            data1 = float.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            data1 = float.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            data1 = float.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                data2 = data1 + float.Parse(textBox1.Text);
                textBox1.Text = data2.ToString();
            }
            if (pheptinh == "tru")
            {
                data2 = data1 - float.Parse(textBox1.Text);
                textBox1.Text = data2.ToString();
            }
            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(textBox1.Text);
                textBox1.Text = data2.ToString();
            }
            if (pheptinh == "chia")
            {
                if (float.Parse(textBox1.Text) == 0)
                {
                    textBox1.Text = "ERROR";
                }
                else
                {
                    data2 = data1 / float.Parse(textBox1.Text);
                    textBox1.Text = data2.ToString();
                }
            }
            if (pheptinh == "chia_du")
            {
                if (float.Parse(textBox1.Text) == 0)
                {
                    textBox1.Text = "ERROR";
                }
                else
                {
                    data2 = data1 % float.Parse(textBox1.Text);
                    textBox1.Text = data2.ToString();
                }
            }
            isResultDisplayed = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            data1 = float.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pheptinh = "chia_du";
            data1 = float.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                textBox1.Clear();
                isResultDisplayed = false;
            }
            textBox1.Text = textBox1.Text + "0";
        }
    }
}
