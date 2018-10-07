using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMVDecodeLib
{
    public class EmvcQrDecode
    {

        public static List<EmvcQrDecodeModel> DecodeEMVQRString(string qrStrings)
        {
            try
            {
                var inputText = qrStrings;

                List<EmvcQrDecodeModel> emvcQrDecodeModels = new List<EmvcQrDecodeModel>();

                while (!String.IsNullOrEmpty(inputText))
                {
                    EmvcQrDecodeModel emvcQrDecodeModel = new EmvcQrDecodeModel();
                    emvcQrDecodeModel.ObjectNo = inputText.Substring(0, 2);
                    var s1r = inputText.Substring(2, inputText.Length - 2);
                    emvcQrDecodeModel.DataLength = Convert.ToInt16(s1r.Substring(0, 2));
                    emvcQrDecodeModel.Data = s1r.Substring(2, emvcQrDecodeModel.DataLength);
                    inputText = s1r.Substring(emvcQrDecodeModel.DataLength + 2);

                    emvcQrDecodeModels.Add(emvcQrDecodeModel);

                }

                return emvcQrDecodeModels;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static List<EmvcQrDecodeModel> DecodeEMVQRHexString(string qrStrings)
        {
            try
            {

                byte[] datahexByte = FromHex(qrStrings);
                var inputText = Encoding.UTF8.GetString(datahexByte);

                List<EmvcQrDecodeModel> emvcQrDecodeModels = new List<EmvcQrDecodeModel>();

                while (!String.IsNullOrEmpty(inputText))
                {
                    EmvcQrDecodeModel emvcQrDecodeModel = new EmvcQrDecodeModel();
                    emvcQrDecodeModel.ObjectNo = inputText.Substring(0, 2);
                    var s1r = inputText.Substring(2, inputText.Length - 2);
                    emvcQrDecodeModel.DataLength = Convert.ToInt16(s1r.Substring(0, 2));
                    emvcQrDecodeModel.Data = s1r.Substring(2, emvcQrDecodeModel.DataLength);
                    inputText = s1r.Substring(emvcQrDecodeModel.DataLength + 2);

                    emvcQrDecodeModels.Add(emvcQrDecodeModel);

                }

                return emvcQrDecodeModels;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }
    }
}
