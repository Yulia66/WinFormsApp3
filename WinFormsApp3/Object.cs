using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp3
{
    internal class Plus
    {
        int x, y;
        int w, h;
        Button but1;
        TextBox text1, text2;
        public Plus(int x, int y, int w, int h, Form1 form)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;

            but1 = new Button();
            but1.Width = w /3;
            but1.Height = h / 3;
            but1.Left = x+70;
            but1.Top = y + 50;
            but1. Text="сложить";
            but1.Click += But1_Click;
            form.Controls.Add(but1 );

            text1 = new TextBox();
            text1.Width = w / 4;
            text1.Height = h / 3;
            text1.Left = x + 5;
            text1.Top = y + 5;
            
            form.Controls.Add(text1);


            text2 = new TextBox();
            text2.Width = w / 4;
            text2.Height = h / 3;
            text2.Left = x + 145;
            text2.Top = y + 5;

            form.Controls.Add(text2);

        }

        private void But1_Click(object? sender, EventArgs e)
        {
            double a = Convert.ToDouble(text1.Text);
            double b = Convert.ToDouble(text2.Text);

            double c=a + b;
            MessageBox.Show("Сумма равна: " + c.ToString());
        }

        internal void Paint(Graphics g)
        {
            g.DrawRectangle(Pens.Black, x, y, w, h);
        }
    }
}
