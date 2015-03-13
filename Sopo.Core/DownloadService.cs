using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Sopo.Repository;
using Sopo.Domain;
using Sopo.Domain.Enums;

namespace Sopo.Core
{
    public sealed class DownloadService : ServiceBase
    {
        public void Downolad(string Url, DownloadType downloadType)
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

                string path = _downloadPathRepository.Set().FirstOrDefault(x => x.Type == DownloadType.image).Path;

                if (path == null) throw new Exception("File Path Not Found!");

                string LocalPath = HttpContext.Current.Server.MapPath(path); //Das ist nicht gut!

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
                LogService ls = new LogService();
                ls.CreateLog(ex.Message);
            }
        }
    }
}
