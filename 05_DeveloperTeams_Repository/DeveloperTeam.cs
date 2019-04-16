using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DeveloperTeams_Repository
{
    public class DeveloperTeam
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public List<Developer> Developers { get; set; }

        // A Method that takes in a Developer and adds it to our Developers property
        public void AddDeveloperToTeam(Developer dev)
        {
            dev.EmployeeTeamID = TeamID;
            Developers.Add(dev);
        }
    }
}
