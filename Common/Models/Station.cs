using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        public int? PlaneID { get; set; }
        public Plane Plane { get; set; }
    }
}
