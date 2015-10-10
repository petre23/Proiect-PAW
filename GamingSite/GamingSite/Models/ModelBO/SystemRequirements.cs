using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamingSite.Models.ModelBO
{
    public class SystemRequirements
    {
        public int Game { get; set; }
        public string Processor { get; set; }
        public string OS { get; set; }
        public string Memory { get; set; }
        public int SystemRequirementsId { get; set; }
    }
}