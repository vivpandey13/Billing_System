using System;
using System.IO;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class Form1 : Form
    {
        public string FileName { get; set; }
        public string Input { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (File.Exists(textBox1.Text))
                {
                    Input = File.ReadAllText(textBox1.Text);
                }
                else
                {
                    this.label1.Text = "File does not exists!!";
                }
            }
            else if (radioButton2.Checked)
            {
                Input = textBox1.Text;
            }
            if (!string.IsNullOrWhiteSpace(Input))
            {
                BillingService billingService = new BillingService(Input);
                var totalprice = billingService.CalculateTotalPrice();
                label1.Text = $"Total price is {totalprice}";
            }
        }
    }
}
