using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFComplejidadAlgoritmica.Entity
{
    public class Education
    {
        public int Id { get; set; }

        public String LocalCode { get; set; }
        public String LocalName { get; set; }

        public String CodeSettlement { get; set; }
        public String NameSettlement { get; set; }
        public Double LongitudeE { get; set; }
        public Double LatitudeE { get; set; }

        public Settlement Settlement { get; set; }

    }
}
