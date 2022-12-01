using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinusgenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        float cx, cy, px, py;
        float rad = (float)(180 / Math.PI);
        int mod = -1;
        int del0 = 0;
        int dim = 20;
        int pozy = 250;
        Pen pen0;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
           

        public double secanta(double x)
        {
            return 1 / x;
        }

        public double cosecanta(double x)
        {
            return 1 / x;
        }

        public bool drawfunction()
        {
            if (del0 == 1)
            {
                g.Clear(this.BackColor);
            }
            for (float i = 0.0f; i < 360.0f; i += 1.000f)
            {
                try
                {
                    px = cx;
                    py = cy;
                    //textBox1.Text += "\r\n";
                    //textBox1.Text += Math.Sin(i).ToString();
                    //textBox1.Text += Math.Cos(i).ToString();
                    //textBox1.Text += Math.Tan(i).ToString();
                    //textBox1.Text += ( Math.Cos(i)/Math.Sin(i)).ToString();
                    //textBox1.Text += secanta(Math.Cos(i)).ToString();
                    //textBox1.Text += cosecanta(Math.Sin(i)).ToString();
                    if (mod == 0)
                    {
                        cy = (float)(Math.Sin(i * rad)) * dim + pozy;
                        pen0 = new Pen(Color.Black);
                    }
                    else if (mod == 1)
                    {
                        cy = (float)(Math.Cos(i * rad)) * dim + pozy;
                        pen0 = new Pen(Color.Red);
                    }
                    else if (mod == 2)
                    {
                        cy = (float)(Math.Tan(i * rad)) * dim + pozy;
                        pen0 = new Pen(Color.Green);
                    }
                    else if (mod == 3)
                    {

                        cy = (float)((Math.Cos(i * rad) / Math.Sin(i * rad))) * dim + pozy;
                        pen0 = new Pen(Color.White);
                    }
                    else if (mod == 4)
                    {
                        cy = (float)(secanta(Math.Cos(i * rad))) * dim + pozy;
                        pen0 = new Pen(Color.Silver);
                    }
                    else if (mod == 5)
                    {
                        cy = (float)(cosecanta(Math.Sin(i * rad))) * dim + pozy;
                        pen0 = new Pen(Color.Blue);
                    }


                    cx = i * 2;
                    g.DrawLine(pen0, px, py, cx, cy);
                }
                catch { }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            drawfunction();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mod = 4;
            drawfunction();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mod = 3;
            drawfunction();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mod = 5;
            drawfunction();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mod = 2;
            drawfunction();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mod = 1;
            drawfunction();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mod = 0;
            drawfunction();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            del0 = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            del0 = 0;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Width = 1024;
             g = CreateGraphics();
        
        }
    }
}
