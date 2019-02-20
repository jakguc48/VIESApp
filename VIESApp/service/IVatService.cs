using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIESApp.ServiceReference1;

namespace VIESApp.service
{
    public interface IVatService
    {
        void CreateXML(string vat, string valid, string name, string adress, string requestId);
        Task<checkVatApproxResponse> CheckVatApproxAsync(string country, string vat, string countryReq, string vatReq);
        Task<checkVatResponse> CheckVatAsync(string country, string vat);
    }
}
