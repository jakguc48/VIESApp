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
                checkVatResponse vat = await vatTask;


                if (vat.Body.valid)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendLine("STATUS: AKTYWNY");
                    msg.AppendLine();
                    msg.AppendLine($"NAZWA: {vat.Body.name}");
                    msg.AppendLine();
                    msg.AppendLine($"ADRES: {vat.Body.address}");
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
            var countryCode = cbVACountry.SelectedValue.ToString();
            var vatNumber = txtVANumber.Text;
            var countryCodeRequester = cbVACountryRequester.SelectedValue.ToString();
            var vatNumberRequester = txtVANumberRequester.Text;

            Task<checkVatApproxResponse> vatApproxTask = CheckVatApproxAsync(countryCode, vatNumber, countryCodeRequester, vatNumberRequester);
            checkVatApproxResponse vatApprox = await vatApproxTask;

            if (vatApprox.Body.valid)
            {
                txtVAValid.Text = vatApprox.Body.valid.ToString();
                txtVAName.Text = vatApprox.Body.traderName;
                txtVAAdress.Text = vatApprox.Body.traderAddress;
                txtVAId.Text = vatApprox.Body.requestIdentifier;
            }
            else
            {
                MessageBox.Show("STATUS: NIEAKTYWNY", "Walidacja numeru Vat", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


        #endregion Events


        #region Methods

        private async Task<checkVatApproxResponse> CheckVatApproxAsync(string country, string vat, string countryReq, string vatReq)
        {

            checkVatApproxRequest approxRequest = new checkVatApproxRequest()
            {
                Body = new checkVatApproxRequestBody()
                {
                    countryCode = country,
                    vatNumber = vat,
                    requesterCountryCode = countryReq,
                    requesterVatNumber = vatReq,
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
