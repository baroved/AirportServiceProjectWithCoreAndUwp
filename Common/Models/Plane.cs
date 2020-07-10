using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Plane
    {
        [Key]
        public int Id { get; set; }
        public bool ReadyToMove { get; set; }
        
    }
}
