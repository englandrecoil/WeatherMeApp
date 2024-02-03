using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMeApp
{
    public partial class mainPageForm : Form
    {
        public mainPageForm()
        {
            InitializeComponent();
            cityField.Text = "Type city name";
            cityField.ForeColor = Color.Gray;

        }

        private void cityField_Enter(object sender, EventArgs e)
        {   if (cityField.Text == "Type city name") {
                cityField.Text = "";
                cityField.ForeColor = Color.Black;
            }
        }

        private void cityField_Leave(object sender, EventArgs e)
        {
            if (cityField.Text == "")
            {
                cityField.Text = "Type city name";
                cityField.ForeColor = Color.Gray;
            }
        }

    }
}
