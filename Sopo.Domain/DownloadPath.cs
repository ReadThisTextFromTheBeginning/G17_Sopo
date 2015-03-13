using Sopo.Domain.Enums;
using Sopo.Domain.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain
{
   public class DownloadPath : BaseDeletable
    {
       public string Path { get; set; }
       public DownloadType Type { get; set; }
    }
}
