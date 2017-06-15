using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JASP
{
    public class AppSettings
    {
        public string DatabaseId { get; set; }
        public string CollectionId { get; set; }
        public string DBEndPoint { get; set; }
        public string DBAuthKey { get; set; }
        public string SearchServiceName { get; set; }
        public string SearchServiceKey { get; set; }
    }
}
