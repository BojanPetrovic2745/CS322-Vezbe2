using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_Vezbe2
{
    public partial class Vežbe : Form
    {
        private string vrednost;
        private ArrayList cuvanje;

        public Vežbe()
        {
            InitializeComponent();
            vrednost = "";
            cuvanje = new ArrayList();
        }

        private void AddOperatorToArray(Button bttn)
        {
            cuvanje.Add(vrednost); tbUnesiBroj.Text += bttn.Text; vrednost = "";
            cuvanje.Add(bttn.Text);
            btnDecimalPoint.Enabled = true; SetEnableOperatorBttns(false);
        }
        private void AddToArray(Button bttn)
        {
            vrednost += bttn.Text; tbUnesiBroj.Text += bttn.Text; SetEnableOperatorBttns(true);
        }

        private void Reset()
        {
            vrednost = "";
            tbUnesiBroj.Text = ""; cuvanje.Clear(); btnDecimalPoint.Enabled = true;
        }

        private void SetEnableOperatorBttns(bool enable)
        {
            btnSaberi.Enabled = enable; btnOduzmi.Enabled = enable; btnMnozi.Enabled = enable; btnDeli.Enabled = enable; btnJednako.Enabled = enable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToArray(btnNumber7);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddToArray(btnSaberi);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            try
            {
                cuvanje.Add(vrednost);
                cuvanje.Add(btnJednako.Text);

                float m_res = float.Parse(cuvanje[0].ToString());


                for (int i = 0; i < cuvanje.Count; i++)
                {

                    if (cuvanje[i].ToString() == "+")
                    {

                        
                        m_res += float.Parse(cuvanje[i + 1].ToString());

                        tbUnesiBroj.Text = m_res.ToString();
                    }

                    else if (cuvanje[i].ToString() == "‐")
                    {
                        
                        m_res = m_res - float.Parse(cuvanje[i + 1].ToString());
                        tbUnesiBroj.Text = m_res.ToString();
                    }
                    else if (cuvanje[i].ToString() == "*")
                    {
                        
                        m_res *= float.Parse(cuvanje[i + 1].ToString());
                        tbUnesiBroj.Text = m_res.ToString();
                    }
                    else if (cuvanje[i].ToString() == "/")
                    {
                        
                        m_res /= float.Parse(cuvanje[i + 1].ToString());
                        if (vrednost[i].ToString() == ".")
                        {
                            btnDecimalPoint.Enabled = false;
                        }
                        else
                        {

                            break;
                            //btnDecimalPoint.Enabled = true;
                        }
                    }
                    btnJednako.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
    }
    

    private void btnNumber8_Click(object sender, EventArgs e)
        {
            AddToArray(btnNumber8);
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            AddToArray(btnNumber9);
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            AddToArray(btnNumber4);
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            AddToArray(btnNumber5);
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            AddToArray(btnNumber6);
        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            AddToArray(btnNumber1);
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            AddToArray(btnNumber2);
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            AddToArray(btnNumber3);
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            tbUnesiBroj.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
            AddToArray(btnDecimalPoint);
            btnDecimalPoint.Enabled = false;
        }

        private void btnOduzmi_Click(object sender, EventArgs e)
        {
            AddToArray(btnOduzmi);
        }

        private void btnMnozi_Click(object sender, EventArgs e)
        {
            AddToArray(btnMnozi);
        }

        private void btnDeli_Click(object sender, EventArgs e)
        {
            AddToArray(btnDeli);
        }

        private void tbUnesiBroj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
