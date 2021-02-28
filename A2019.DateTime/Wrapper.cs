using System;
using System.IO;

namespace A2019.Convertor
{
    public class Wrapper
    {

        public string ConvertToBase64String(string pathFile)
        {
            try
            {
                byte[] arrImage = File.ReadAllBytes(pathFile);
                string sBuffer = Convert.ToBase64String(arrImage);
                var val = $"data: image/png; base64, {sBuffer}";
                return val;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }
    }
}
