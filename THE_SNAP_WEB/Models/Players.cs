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

        //stats

        public int GamesPlayed { get; set; }

        public int PassAttempts { get; set; }

        public int CompletedPasses { get; set; }

        public int PassTDs { get; set; }

        public int PassYards { get; set; }

        public int Interceptions { get; set; }

        public int RushTDs { get; set; }

        public int RushYards { get; set; }

        public int Fumbles { get; set; }

        public int ForcedFumbles { get; set; }

        public int FumbleRecoveries { get; set; }

        public int Tackles { get; set; }

        public int Sacks { get; set; }

        public int SacksAllowed { get; set; }

        public int ReceivingYards { get; set; }

        public int ReceivingTDs { get; set; }


    }
}
