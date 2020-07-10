using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class EstimatedTakeOff
    {
        [Key]
        public int Id { get; set; }
        public int FlightNum { get; set; }
        public DateTime EstimatedTime { get; set; }
        public int PlaneID { get; set; }
        public Plane Plane { get; set; }
    }
}
