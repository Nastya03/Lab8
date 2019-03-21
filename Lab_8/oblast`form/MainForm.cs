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
    public partial class fMain : Form
    {
        private BindingList<Area> areas = new BindingList<Area>();
        public fMain()
        {
            InitializeComponent();
            tMain.DataSource = areas;
            tMain.DisplayMember = "Name";
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void bAddA_Click(object sender, EventArgs e)
        {
            Area area = new Area();
            FArea ft = new FArea(area);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                areas.Add(area);
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
                "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }


        private void tMain_SelectedIndexChanged(object sender, EventArgs e)
        {

            Area area = (Area)tMain.SelectedItem;
            MessageBox.Show("Область: " + area.Name + ", " +
                area.Country + " | Админістративний центр: " +
                area.Center + "\r\nНайвища точка: " +
                area.Height + "м | Населення: " +
                area.Population + "тис." + "\r\nНаявність порту: " +
                area.HasPort + " | Наявність аеропорту: " +
                area.HasAirport + "\r\nГустина населення: " + area.GetSignPerInhabitant() + "людей/кв.км", " Інформація о області");
        }
    }
}
