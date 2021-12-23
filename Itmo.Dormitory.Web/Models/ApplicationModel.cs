using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itmo.Dormitory.Web.Models
{
    public class ApplicationModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Owner { get; set; }
        public bool Status { get; set; }
        public string ApplicationType { get; set; }
    }
}
