using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.EntityLayer.Concrete
{
   public class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehicleType { get; set; }
        public string Plate { get; set; }
        public AppUser AppUser { get; set; }
    }
}
