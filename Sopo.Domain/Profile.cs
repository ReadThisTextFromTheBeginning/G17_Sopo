using Sopo.Repository.BaseTypes;
using Sopo.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository
{
    public class Profile : BaseDeletable
    {
        public Picture ProfilePicture { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AboutMe { get; set; }
        public uint Age { get; set; }
        public Gender Gender { get; set; }
        public Status Status { get; set; }
        public Education Education { get; set; }
        public string Profession { get; set; }
        public string Attraction { get; set; }
        public Country Location { get; set; }

        public User User { get; set; }
    }
}
