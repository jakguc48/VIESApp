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
            PrepareComponents();
            PrepareCountryCombo(cbVCountry);
            PrepareCountryCombo(cbVACountry);
            PrepareCountryCombo(cbVACountryRequester);

        }

        #endregion Ctor

        #region Events

        private async void btnVCheck_Click(object sender, EventArgs e)
        {
            var countryCode = cbVCountry.SelectedValue.ToString();
            var vatNumber = txtVNumber.Text;
            if (!string.IsNullOrEmpty(vatNumber))
            {
                Task<checkVatResponse> vatTask = CheckVatAsync(countryCode, vatNumber);
                checkVatResponse vatApprox = await vatTask;


                if (vatApprox.Body.valid)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendLine("STATUS: AKTYWNY");
                    msg.AppendLine();
                    msg.AppendLine($"NAZWA: {vatApprox.Body.name}");
                    msg.AppendLine();
                    msg.AppendLine($"ADRES: {vatApprox.Body.address}");
                    MessageBox.Show(msg.ToString(), "Walidacja numeru Vat", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("STATUS: NIEAKTYWNY", "Walidacja numeru Vat", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

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


        private async Task<checkVatResponse> CheckVatAsync(string country, string vat)
        {

            checkVatRequest vatRequest = new checkVatRequest()
            {
                Body = new checkVatRequestBody()
                {
                    countryCode = country,
                    vatNumber = vat
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

        private void PrepareComponents()
        {
            txtVANumber.Text = "6342709934";
            txtVANumberRequester.Text = "6342709934";
            PrepareCountryCombo(cbVCountry);
            PrepareCountryCombo(cbVACountry);
            PrepareCountryCombo(cbVACountryRequester);
        }

        #endregion Methods
    }
}
