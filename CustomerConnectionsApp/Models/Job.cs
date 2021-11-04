using CustomerConnectionsApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConnectionsApp.Models
{
    public class Job : DomainObjectId
    {
        public string strJobNumber { get; set; }
        public string strConnectionApplication { get; set; }
        public string strConnectionNumber { get; set; }
        public string strUsername { get; set; }
        public string strPassword { get; set; }
        public string strAdditionalInformation { get; set; }

        //foreign key, one customer many jobs
        public int intCustomerId { get; set; }
        public Customer Customer { get; set; }

        //many hardwares one job
        public ICollection<Hardware> Hardwares { get; set; }
    }
}
