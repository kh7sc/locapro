using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locapro
{
    internal class Sport_equipment
    {
        private string skill_level;
        private string season;

        public Sport_equipment(string skill_level, string season)
        {
            this.Skill_level = skill_level;
            this.Season = season;
        }

        public string Skill_level { get => skill_level; set => skill_level = value; }
        public string Season { get => season; set => season = value; }
    }
}
