using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VIESApp.ServiceReference1;

namespace VIESApp.service
{
    class VatService :IVatService
    {
        public void CreateXML(string vat, string valid, string name, string adress, string requestId)
        {
            XDocument doc = new XDocument(new XElement("ViesVatValidation",
                new XElement("Vat", vat),
                new XElement("Valid", valid),
                new XElement("Name", name),
                new XElement("Adress", adress),
                new XElement("RequestId", requestId)));
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "xml files (*.xml)|*.xml";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    doc.Save(dialog.FileName);
                }
            }
        }

        public async Task<checkVatApproxResponse> CheckVatApproxAsync(string country, string vat, string countryReq, string vatReq)
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

        public async Task<checkVatResponse> CheckVatAsync(string country, string vat)
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
    }
}
