using SpiderApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace SpiderApp.Controllers
{
    public class BallInfoController : ApiController
    {
        public BallInfo GetBallInfo()
        {
            obtainMatchInfo();
            return null;
        }

        public void obtainMatchInfo()
        {
            Debug.WriteLine("obtainingMatchInfo");
            string url = "http://bet.hkjc.com/football/default.aspx";
            //string url = "http://www.google.com";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StringBuilder sb = new StringBuilder();
            Byte[] buf = new byte[8192];
            
            Stream resStream = response.GetResponseStream();
            var count = 0;
            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    sb.Append(Encoding.GetEncoding(950).GetString(buf, 0, count)); 
                }
            } while (count > 0);
            String html = sb.ToString();
            Debug.WriteLine(html);
            Debug.WriteLine("omg");
        }
    }
}
