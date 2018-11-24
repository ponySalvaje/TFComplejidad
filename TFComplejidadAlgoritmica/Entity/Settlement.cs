using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFComplejidadAlgoritmica.Entity
{
    public class Settlement
    {
        public int Id { get; set; }

        public String Code { get; set; }
        public String Name { get; set; }
        public String Region { get; set; }
        public String Province { get; set; }
        public String District { get; set; }
        public Double Longitude { get; set; }
        public Double Latitude { get; set; }
        public int IsCapital { get; set; }
    }



    

}
