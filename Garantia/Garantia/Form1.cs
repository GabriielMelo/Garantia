using System.Threading.Tasks.Dataflow;

namespace Garantia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getDate();
            totalLabel();

        }



        private void qt1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qtLinha = 0;
            double precoU = Convert.ToDouble(precoUnitarioLinha1.Text.Trim());
            double vTotal;

            if (qt1.SelectedItem != null)
            {
                qtLinha = Convert.ToInt32(qt1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Quantidade Inválida");
            }
            vTotal = qtLinha * precoU;
            totalLinha1.Text = vTotal.ToString() + ",00";
            lblValorTotal.Text = ValorTotal().ToString() + ",00";
        }

        private void totalLabel()
        {
            totalLinha1.Enabled = false;
            totalLinha2.Enabled = false;
            totalLinha3.Enabled = false;
            totalLinha4.Enabled = false;
            totalLinha5.Enabled = false;
            totalLinha6.Enabled = false;
        }

        private void getDate()
        {
            DateTime date = DateTime.Now;
            String formatedData = date.ToString("dd/MM/yyyy HH:mm");
            lbldataAtual.Text = formatedData;
            ;
        }

        private double ValorTotal()
        {
            double l1 = Convert.ToDouble(totalLinha1.Text.Trim());
            double l2 = Convert.ToDouble(totalLinha2.Text.Trim());
            double l3 = Convert.ToDouble(totalLinha3.Text.Trim());
            double l4 = Convert.ToDouble(totalLinha4.Text.Trim());
            double l5 = Convert.ToDouble(totalLinha5.Text.Trim());
            double l6 = Convert.ToDouble(totalLinha6.Text.Trim());
            double valorTotal = l1 + l2 + l3 + l4 + l5 + l5;
            return valorTotal;
        }

        private void qt2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qtLinha = 0;
            double precoU = Convert.ToDouble(precoUnitarioLinha2.Text.Trim());
            double vTotal;

            if (qt2.SelectedItem != null)
            {
                qtLinha = Convert.ToInt32(qt2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Quantidade Inválida");
            }
            vTotal = qtLinha * precoU;
            totalLinha2.Text = vTotal.ToString() + ",00";
            lblValorTotal.Text = ValorTotal().ToString() + ",00";
        }

        private void qt3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qtLinha = 0;
            double precoU = Convert.ToDouble(precoUnitarioLinha3.Text.Trim());
            double vTotal;

            if (qt3.SelectedItem != null)
            {
                qtLinha = Convert.ToInt32(qt3.SelectedItem);
            }
            else
            {
                MessageBox.Show("Quantidade Inválida");
            }
            vTotal = qtLinha * precoU;
            totalLinha3.Text = vTotal.ToString() + ",00";
            lblValorTotal.Text = ValorTotal().ToString() + ",00";
        }

        private void qt4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qtLinha = 0;
            double precoU = Convert.ToDouble(precoUnitarioLinha4.Text.Trim());
            double vTotal;

            if (qt4.SelectedItem != null)
            {
                qtLinha = Convert.ToInt32(qt4.SelectedItem);
            }
            else
            {
                MessageBox.Show("Quantidade Inválida");
            }
            vTotal = qtLinha * precoU;
            totalLinha4.Text = vTotal.ToString() + ",00";
            lblValorTotal.Text = ValorTotal().ToString() + ",00";
        }

        private void qt5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qtLinha = 0;
            double precoU = Convert.ToDouble(precoUnitarioLinha5.Text.Trim());
            double vTotal;

            if (qt5.SelectedItem != null)
            {
                qtLinha = Convert.ToInt32(qt5.SelectedItem);
            }
            else
            {
                MessageBox.Show("Quantidade Inválida");
            }
            vTotal = qtLinha * precoU;
            totalLinha5.Text = vTotal.ToString() + ",00";
            lblValorTotal.Text = ValorTotal().ToString() + ",00";
        }

        private void qt6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qtLinha = 0;
            double precoU = Convert.ToDouble(precoUnitarioLinha6.Text.Trim());
            double vTotal;

            if (qt6.SelectedItem != null)
            {
                qtLinha = Convert.ToInt32(qt6.SelectedItem);
            }
            else
            {
                MessageBox.Show("Quantidade Inválida");
            }
            vTotal = qtLinha * precoU;
            totalLinha6.Text = vTotal.ToString() + ",00";
            lblValorTotal.Text = ValorTotal().ToString() + ",00";
        }
    }
}
