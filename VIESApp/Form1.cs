using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
            VCheckAsync();
        }

        private void btnVACheck_Click(object sender, EventArgs e)
        {
            VACheckAsync();
        }

        private void btnVAXml_Click(object sender, EventArgs e)
        {
            _vatService.CreateXML(txtVAVat.Text, txtVAValid.Text, txtVAName.Text, txtVAAdress.Text, txtVAId.Text, txtVADate.Text, txtVACountry.Text);
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

        private async void VCheckAsync()
        {
            Task<checkVatResponse> vatTask = _vatService.CheckVatAsync(cbVCountry.SelectedValue.ToString(), txtVNumber.Text);

            checkVatResponse vat = new checkVatResponse();
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
                    MessageBox.Show(msg.ToString(), "Walidacja numeru Vat", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("STATUS: NIEAKTYWNY", "Walidacja numeru Vat", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "INVALID_INPUT")
                {
                    MessageBox.Show("Wartość pola Vat nie może być pusta", "Błąd", MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation);
                }
                else if (ex.Message == "GLOBAL_MAX_CONCURRENT_REQ")
                {
                    MessageBox.Show("Maksymalna ilość konkurencyjnych zapytań została przekroczona. Spróbuj ponownie później", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ex.Message == "MS_MAX_CONCURRENT_REQ")
                {
                    MessageBox.Show("Maksymalna ilość konkurencyjnych zapytań została przekroczona. Spróbuj ponownie później", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ex.Message == "SERVICE_UNAVAILABLE")
                {
                    MessageBox.Show("Wystąpił błąd sieci lub serwera VIES. Spróbuj ponownie później", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ex.Message == "MS_UNAVAILABLE")
                {
                    MessageBox.Show("Wystąpił błąd sieci lub serwera VIES. Spróbuj ponownie później", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ex.Message == "TIMEOUT")
                {
                    MessageBox.Show("Oczekiwana odpowiedź nie została uzyskana w określonych ramach czasowych. Spróbuj ponownie później", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd aplikacji", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private async void VACheckAsync()
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
                    txtVADate.Text = vatApprox.Body.requestDate;
                    txtVACountry.Text = vatApprox.Body.countryCode;
                    btnVAXml.Enabled = true;
                }
                else
                {
                    MessageBox.Show("STATUS: NIEAKTYWNY", "Walidacja numeru Vat", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                if (ex.Message == "INVALID_REQUESTER_INFO")
                {
                    MessageBox.Show("Niepoprawna wartość numeru vat pytającego dla wybranego kraju", "Błędny vat", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else if (ex.Message == "Empty Requester VAT number")
                {
                    MessageBox.Show("Wartość numeru vat pytającego nie może być pusta", "Błędny vat", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else if (ex.Message == "GLOBAL_MAX_CONCURRENT_REQ")
                {
                    MessageBox.Show("Maksymalna ilość konkurencyjnych zapytań została przekroczona. Spróbuj ponownie później", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ex.Message == "MS_MAX_CONCURRENT_REQ")
                {
                    MessageBox.Show("Maksymalna ilość konkurencyjnych zapytań została przekroczona. Spróbuj ponownie później", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ex.Message == "SERVICE_UNAVAILABLE")
                {
                    MessageBox.Show("Wystąpił błąd sieci lub serwera VIES. Spróbuj ponownie później", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ex.Message == "MS_UNAVAILABLE")
                {
                    MessageBox.Show("Wystąpił błąd sieci lub serwera VIES. Spróbuj ponownie później", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (ex.Message == "TIMEOUT")
                {
                    MessageBox.Show("Oczekiwana odpowiedź nie została uzyskana w określonych ramach czasowych. Spróbuj ponownie później", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd aplikacji", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        #endregion Methods


    }
}
