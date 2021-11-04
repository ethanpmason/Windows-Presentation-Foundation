using CustomerConnectionsApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConnectionsApp.Models
{
    public class Hardware : DomainObjectId
    {
        public string strName { get; set; }
        public string strDescription { get; set; }
        public string strIPAddress { get; set; }
        public string strSubnetMask { get; set; }
        public string strDefaultGateway { get; set; }
        public string strUsername { get; set; }
        public string strPassword { get; set; }

        //foreign key, one job many hardwares
        public int intJobId { get; set; }
        public Job Job { get; set; }
    }
}
