using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using THE_SNAP_WEB.Models;

namespace THE_SNAP_WEB.Models
{
    public class Players
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Teams Team { get; set; }

        public int Age { get; set; }

        public int Height { get; set; }

        public double Weight { get; set; }

        public string Position { get; set; }
    }
}
