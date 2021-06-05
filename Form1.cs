using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пратика_3
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
      double x = Convert.ToDouble(textBox1.Text);
      textBox4.Text = "Результаты работы программы: " + Environment.NewLine;
      textBox4.Text += "При X = " + textBox4.Text + Environment.NewLine;
      int n = 0;
      if (radioButton2.Checked) 
        n = 1;
      if (radioButton3.Checked) 
        n = 2;
      double u;
      switch (n) 
      {
        case 0:
          if (x > 3)
          {
            u = 0.5 * Math.Sinh(x);
          }
          else if ((x >= 0) && (x <= 3))
          {
            u = 2;
          }
          else
          {
            u = 1 / Math.Sinh(x);
          }
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 1:
          if (x > 3)
          {
            u = 0.5 * Math.Cosh(x);
          }
          else if ((x >= 0) && (x <= 3))
          {
            u = 2;
          }
          else
          {
            u = 1 / Math.Sinh(x);
          }
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 2:
          if (x > 3)
          {
            u = 0.5 * Math.Exp(x);
          }
          else if ((x >= 0) && (x <= 3))
          {
            u = 2;
          }
          else
          {
            u = 1 / Math.Exp(x);
          }
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        default:
          textBox4.Text += "Решение не найдено " + Environment.NewLine;
          break;
      }
    }
  }
}
