using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpTool
{
    public partial class FrmHttpTool : Form
    {
        public FrmHttpTool()
        {
            InitializeComponent();
        }

        private void btnSender_Click(object sender, EventArgs e)
        {
            string code = string.Empty;
            string response = string.Empty;
            switch (cmbHttpType.SelectedIndex)
            {
                case 0:

                    response = HttpClientHelper.GetResponse(txtURL.Text, out code);
                    lblStatusCode.Text = code;
                    txtResonse.Text = response;
                    break;
                case 1:
                    code = string.Empty;
                    response = string.Empty;
                    response = HttpClientHelper.PostResponse(txtURL.Text, txtContent.Text, out code);
                    lblStatusCode.Text = code;
                    txtResonse.Text = response;
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }

    }
}
