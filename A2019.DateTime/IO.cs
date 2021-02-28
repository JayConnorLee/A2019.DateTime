using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace A2019.Convertor
{
    class IO
    {
        //comment
        public string ReadFromFile(string pathFile)
        {
            try
            {
                return File.ReadAllText(pathFile, Encoding.Default);
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public string WriteToFile(string pathFile, string contents, bool append = false, string encoding = "")
        {
            try
            {   
                
                Encoding en = Encoding.Default;
                if (encoding != "") { en = Encoding.GetEncoding(encoding); }
                if (append)
                    File.AppendAllText(pathFile, contents, en);
                else
                    File.WriteAllText(pathFile, contents, en);

                return "";

            }catch(Exception e)
            {
                return e.Message;
            }
        }

    }
}
