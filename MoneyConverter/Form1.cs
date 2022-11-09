using MoneyConverter.Core.Exceptions;
using MoneyConverter.Core.Extentions;
using System;
using System.Windows.Forms;

namespace MoneyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Number must be greater than 0");
            }
            else
            {

                try
                {

                    richTextBox1.Text = numericUpDown1.Value.ConvertToWord();

                }
                catch (DecimalOutOfRangeException)
                {
                    MessageBox.Show("Only 2 digits after comma is allowed");
                }
                catch (NumberOutOfLengthException)
                {
                    MessageBox.Show("The input number is too large");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }
}