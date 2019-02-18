using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIESApp.enums;

namespace VIESApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbVCountry.DataSource = Enum.GetValues(typeof(CountryEnum));
            
        }

        private void btnVCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbVCountry.SelectedItem.ToString());
        }
    }
}
