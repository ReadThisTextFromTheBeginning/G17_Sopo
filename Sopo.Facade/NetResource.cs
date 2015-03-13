using Sopo.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Sopo.Core;
using System.Web;

namespace Sopo.Facade
{

    public class NetResource
    {
        public static void Downolad(string Url, string saveLocation)
        {
            try
            {
                byte[] Bytes;
                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(Url);

                Request.Timeout = 10000;

                WebResponse imageResponse = Request.GetResponse();

                Stream responseStream = imageResponse.GetResponseStream();

                using (BinaryReader br = new BinaryReader(responseStream))
                {
                    Bytes = br.ReadBytes(500000);
                    br.Close();
                }
                responseStream.Close();
                imageResponse.Close();

                string LocalPath = HttpContext.Current.Server.MapPath(saveLocation); //Das ist nicht gut!

                FileStream fs = new FileStream(LocalPath, FileMode.Create);
                Console.WriteLine(fs.Name);
                BinaryWriter bw = new BinaryWriter(fs);
                try
                {
                    bw.Write(Bytes);

                }
                finally
                {
                    fs.Close();
                    bw.Close();
                }
            }
            catch (Exception ex)
            {
                

               // LogRepository logRepository = new LogRepository();
                
               //logRepository.ExceptionLog(ex);
            }
        }
    }
}
