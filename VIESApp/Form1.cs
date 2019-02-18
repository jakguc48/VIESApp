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
            MessageBox.Show(cbVCountry.SelectedValue.ToString());
            var alfa = cbVCountry.SelectedItem;

            string asd = CountryEnum.AT.AsString(EnumFormat.Description);
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
