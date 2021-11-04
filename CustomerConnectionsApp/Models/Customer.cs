using CustomerConnectionsApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConnectionsApp.Models
{
    public class Customer : DomainObjectId
    {
        public string strName { get; set; }
        public char chrCode { get; set; }
        public string strAddress { get; set; }
        public string strCity { get; set; }
        public string strState { get; set; }
        public string strZipCode { get; set; }

        //many jobs one customer
        public ICollection<Job> Jobs { get; set; }
    }
}
