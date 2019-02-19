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
            bool Valid;
            string name;
            string address;

            if (!string.IsNullOrEmpty(vatNumber))
            {
                using (ServiceReference1.checkVatPortTypeClient client = new checkVatPortTypeClient())
                {
                    client.checkVat(ref countryCode, ref vatNumber, out Valid, out name, out address);
                }

                if (Valid)
                {
                    MessageBox.Show("Podany numer Vat jest aktywny", "Validation", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Podany numer vat jest nieaktywny", "Validation", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość numeru vat", "ValidationNum", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }



        }

        

       

        private async void btnVACheck_Click(object sender, EventArgs e)
        {
            Task<checkVatApproxResponse> vatApproxTask = CheckVatApproxAsync();
            checkVatApproxResponse vatApprox = await vatApproxTask;

            string vatNumber = txtVNumber.Text;

        }


        #endregion Events


        #region Methods

        private async Task<checkVatApproxResponse> CheckVatApproxAsync()
        {

            checkVatApproxRequest approxRequest = new checkVatApproxRequest()
            {
                Body = new checkVatApproxRequestBody()
                {
                    countryCode = "PL",
                    requesterCountryCode = "PL",
                    requesterVatNumber = "6342704",
                    vatNumber = "6342709934",
                    traderCity = "",
                    traderCompanyType = "",
                    traderName = "",
                    traderPostcode = "",
                    traderStreet = ""
                }
            };

            checkVatApproxResponse approxResponse = new checkVatApproxResponse();

            using (ServiceReference1.checkVatPortTypeClient client = new checkVatPortTypeClient())
            {
                approxResponse = await client.checkVatApproxAsync(approxRequest.Body.countryCode,
                    approxRequest.Body.requesterVatNumber, approxRequest.Body.traderName, approxRequest.Body.traderCompanyType, approxRequest.Body.traderStreet,
                    approxRequest.Body.traderPostcode, approxRequest.Body.traderCity, approxRequest.Body.requesterCountryCode, approxRequest.Body.requesterVatNumber);

                return approxResponse;
            }
            
        }


        private async Task<checkVatResponse> CheckVatAsync()
        {

            checkVatRequest vatRequest = new checkVatRequest()
            {
                Body = new checkVatRequestBody()
                {
                    countryCode = "PL",
                    vatNumber = "6342709934"
                }
            };

            checkVatResponse vatResponse = new checkVatResponse();

            using (ServiceReference1.checkVatPortTypeClient client = new checkVatPortTypeClient())
            {
                vatResponse = await client.checkVatAsync(vatRequest.Body.countryCode, vatRequest.Body.vatNumber);

                return vatResponse;
            }

        }


        private void PrepareCountryCombo(ComboBox cb)
        {
            cb.DataSource = Enum.GetValues(typeof(CountryEnum))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                        typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description,
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
