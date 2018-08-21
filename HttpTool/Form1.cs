using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            string status = string.Empty;
            txtResonse.Text= HttpClientHelper.GetResponse("http://www.baidu.com", out status);
            txtResonse.Text = HttpClientHelper.RestfulGet("http://www.baidu.com");
        }
    }
}
