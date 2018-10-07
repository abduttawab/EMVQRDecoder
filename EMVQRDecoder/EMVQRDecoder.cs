using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMVDecodeLib;

namespace EMVQRDecoder
{
    public partial class EMVQRDecoder : Form
    {
        public EMVQRDecoder()
        {
            InitializeComponent();
        }

        private void decodeUtf8QRBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var input = textUtf8.Text;
                if (!String.IsNullOrEmpty(input))
                {
                   var result = EmvcQrDecode.DecodeEMVQRString(input);

                    decodedResultGrid.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Give QR String!!!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid String!!!!");
            }
        }

        private void decodeHexQRBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var input = textHex.Text;
                if (!String.IsNullOrEmpty(input))
                {
                    var result = EmvcQrDecode.DecodeEMVQRHexString(input);

                    decodedResultGrid.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Give QR HEX String!!!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid String!!!!");
               
            }
        }
    }
}
