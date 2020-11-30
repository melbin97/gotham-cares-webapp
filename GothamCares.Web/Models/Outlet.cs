using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCares.Web.Models
{
    public class Outlet
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string StreetName { get; set; }
        public string Landmark { get; set; }
        public int ReqVolunteers { get; set; }
        //public List<Food> Foods { get; set; }
    }
}
