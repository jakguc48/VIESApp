using System;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIESApp.enums;
using VIESApp.service;
using VIESApp.ServiceReference1;

namespace VIESApp
{
    public partial class Form1 : Form
    {
        #region Properties

        public IVatService _vatService = new VatService();

        #endregion

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
            if (!string.IsNullOrEmpty(txtVNumber.Text))
            {
                Task<checkVatResponse> vatTask = _vatService.CheckVatAsync(cbVCountry.SelectedValue.ToString(), txtVNumber.Text);

                checkVatResponse vat= new checkVatResponse();
                try
                {
                    vat = await vatTask;
                    if (vat.Body.valid)
                    {
                        StringBuilder msg = new StringBuilder();
                        msg.AppendLine("STATUS: AKTYWNY");
                        msg.AppendLine();
                        msg.AppendLine($"NAZWA: {vat.Body.name}");
                        msg.AppendLine();
                        msg.AppendLine($"ADRES: {vat.Body.address}");
                        MessageBox.Show(msg.ToString(), "Walidacja numeru Vat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("STATUS: NIEAKTYWNY", "Walidacja numeru Vat", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (ProtocolException exception)
                {

                    MessageBox.Show("Wystąpił błąd serwera VIES", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wartość pola Vat nie może być pusta", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        
        private async void btnVACheck_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVANumber.Text) && !string.IsNullOrEmpty(txtVANumberRequester.Text))
            {
                Task<checkVatApproxResponse> vatApproxTask = _vatService.CheckVatApproxAsync(
                    cbVACountry.SelectedValue.ToString(), txtVANumber.Text,
                    cbVACountryRequester.SelectedValue.ToString(), txtVANumberRequester.Text);

                checkVatApproxResponse vatApprox = new checkVatApproxResponse();
                try
                {
                    vatApprox = await vatApproxTask;
                    if (vatApprox.Body.valid)
                    {
                        txtVAValid.Text = vatApprox.Body.valid.ToString();
                        txtVAName.Text = vatApprox.Body.traderName;
                        txtVAAdress.Text = vatApprox.Body.traderAddress;
                        txtVAId.Text = vatApprox.Body.requestIdentifier;
                        txtVAVat.Text = vatApprox.Body.vatNumber;
                        btnVAXml.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("STATUS: NIEAKTYWNY", "Walidacja numeru Vat", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (ProtocolException exception)
                {
                    MessageBox.Show("Wystąpił błąd serwera VIES", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Wartość pól Vat nie może być pusta", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnVAXml_Click(object sender, EventArgs e)
        {
            _vatService.CreateXML(txtVAVat.Text, txtVAValid.Text, txtVAName.Text, txtVAAdress.Text, txtVAId.Text);
        }

        #endregion Events

        #region Methods

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
            btnVAXml.Enabled = false;
        }

        #endregion Methods

        
    }
}
