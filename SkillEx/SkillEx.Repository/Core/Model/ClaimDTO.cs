using System;
using System.Collections.Generic;
using System.Text;

namespace SkillEx.Repository.Core.Model
{
    public class ClaimDTO
    {
        public string Type { get; set; }
        public string DOI { get; set; }
        public string Number { get; set; }
        public Dictionary<string, string> Claimant { get; set; }
    }
}
