using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab8Lib;


namespace oblast_form
{
    public partial class FArea : Form
    {
        public Area TheArea;

        internal FArea(Area t)
        {
            TheArea = t;

            InitializeComponent();
        }

        private void fArea_Load(object sender, EventArgs e)
        {
            if (TheArea != null)
            {
                tbName.Text = TheArea.Name;
                tbCountry.Text = TheArea.Country;
                tbCenter.Text = TheArea.Center;
                tbPop.Text = TheArea.Population.ToString();
                tbHeight.Text = TheArea.Height.ToString();
                tbSquare.Text = TheArea.Square.ToString();
                chPort.Checked = TheArea.HasPort; chAir.Checked = TheArea.HasAirport;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            TheArea.Name = tbName.Text.Trim();
            TheArea.Country = tbCountry.Text.Trim();
            TheArea.Center = tbCenter.Text.Trim();
            TheArea.Population = int.Parse(tbPop.Text.Trim());
            TheArea.Height = int.Parse(tbHeight.Text.Trim());
            TheArea.Square = int.Parse(tbSquare.Text.Trim());
            TheArea.HasPort = chPort.Checked;
            TheArea.HasAirport = chAir.Checked;

            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbPop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                MessageBox.Show("Заборонено використання літер та десяткових чисел.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void tbHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                MessageBox.Show("Заборонено використання літер та десяткових чисел.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void tbSquare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                MessageBox.Show("Заборонено використання літер та десяткових чисел.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
