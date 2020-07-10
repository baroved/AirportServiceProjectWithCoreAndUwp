using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class ConnecedStation
    {
        [Key]
        public int Id { get; set; }
        public int FromStationID { get; set; }
        public Station FromStation { get; set; }
        public int? ToStationID { get; set; }
        public Station ToStation { get; set; }
    }
}
