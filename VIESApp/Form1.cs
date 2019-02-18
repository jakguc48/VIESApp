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
using EnumsNET;
using VIESApp.ServiceReference1;

namespace VIESApp
{
    public partial class Form1 : Form
    {
        #region Ctor

        public Form1()
        {
            InitializeComponent();
            PrepareCountryCombo(cbVCountry);

        }

        #endregion Ctor

        #region Events

        private void btnVCheck_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbVCountry.SelectedValue.ToString());
            //var alfa = cbVCountry.SelectedItem;

            //string asd = CountryEnum.AT.AsString(EnumFormat.Description);

           
            string countryCode = cbVCountry.SelectedValue.ToString();
            string vatNumber = txtVNumber.Text;
            bool isValid;
            string name;
            string address;

            if (!string.IsNullOrEmpty(vatNumber))
            {
                using (ServiceReference1.checkVatPortTypeClient client = new checkVatPortTypeClient())
                {

                    client.checkVat(ref countryCode, ref vatNumber, out isValid, out name, out address);
                }

                if (isValid)
                {
                    MessageBox.Show("Podany numer Vat jest aktywny", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Podany numer vat jest nieaktywny", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość numeru vat", "ValidationNum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           


        }

        #endregion Events

        #region Methods

        private void PrepareCountryCombo(ComboBox cb)
        {
            cb.DataSource = Enum.GetValues(typeof(CountryEnum))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();

            cb.DisplayMember = "Description";
            cb.ValueMember = "Value";
            cb.SelectedIndex = (int)CountryEnum.PL;
        }

        #endregion Methods



    }
}
