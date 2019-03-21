using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8Lib
{
    public class Area
    {
        public int Id { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string country;
        public string Country
        {
            get { return country; }
            set
            {
                if (!value.Equals("Україна") &&
                    !value.Equals("Польща") &&
                    !value.Equals("США") &&
                    !value.Equals("Фрнція") &&
                    !value.Equals("Германія"))
                {
                    MessageBox.Show("Цю країну не можна додати.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidCountryException();
                }
                else
                {
                    country = value;
                }
            }
        }

        private string center;
        public string Center
        {
            get { return center; }
            set { center = value; }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 8849)
                {
                    MessageBox.Show("Неможлива висота", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidHeightException();
                }
                else
                {
                    height = value;
                }
            }
        }


        public int Population { get; set; }

        public int Square { get; set; }

        public bool HasPort { get; set; }
        public bool HasAirport { get; set; }

        public double GetSignPerInhabitant()
        {
            return Population / Square;
        }

    }
}