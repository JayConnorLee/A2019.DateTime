
using System;
using System.IO;
using sys = System;

namespace A2019.DateTime
{
    class Program
    {
        public static void Main(string[] arg)
        {
            //comment
            sys.DateTime n1 = sys.DateTime.Now;
            sys.DateTime n2 = sys.DateTime.Now;
            DateTime dt = new DateTime();
            string k = dt.DateDiff(n1, n2, "Milliseconds");
            //string pathSaveTo = @"c:\test222.txt";
            //sys.DateTime d2 = sys.DateTime.Parse("2010-08-20T15:00:00Z", null, System.Globalization.DateTimeStyles.RoundtripKind);
            //sys.DateTime d3 = sys.DateTime.Parse("2021-02-01T12:30:08+09:00", null, System.Globalization.DateTimeStyles.RoundtripKind);

            //string s1 = "2021-02-01T12:30:08+09:00";
            //string s2 = "2021-02-01T16:30:22+09:00";

            //DateTime dt = new DateTime();

            //string k = dt.DateDiff(s1, s2);

            ////Console.WriteLine(k);

            //Console.WriteLine("ee");


            //Console.WriteLine(d2.)
            //for (int i = 1; i <= 10; i++)
            //{
            //    string HTMLBody;
            //    string Attachments;
            //    HTMLBody = System.IO.File.ReadAllText("c:\\test.txt");
            //    HTMLBody = "<img src='c:\\jenny.png'><br>" + HTMLBody;
            //    Attachments = "c:\\jenny.png;c:\\test.test.txt";
            //    Wrapper.Send("jongchan.lee@power-gen.co.kr", "jongchan.lee@power-gen.co.kr", HTMLBody: HTMLBody,Attachments:Attachments);
            //}

        }

    }

}
