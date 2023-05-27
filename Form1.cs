using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Sinema_Salonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int say = 0;

            
            panel1.Controls.Clear();

            
            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                for (int j = 0; j < textBox1.Lines[i].Count(); j++)
                {
                    string satir = textBox1.Lines[i];

                    
                    if (satir[j] == '*')
                    {
                        
                        Button nesne = new Button();
                        nesne.Name = "buton" + i;
                        nesne.Text = (++say).ToString();
                        nesne.BackColor = Color.Red;
                        nesne.Width = nesne.Height = 30;
                        nesne.Left = 35 * j;
                        nesne.Top = 35 * i;

                       
                        nesne.Click += koltukSecildi;

                        
                        panel1.Controls.Add(nesne);
                    }
                }
            }
        }
        void koltukSecildi(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.Red)
                btn.BackColor = Color.Aqua;
            else
                btn.BackColor = Color.Red;

        }
    }
}
