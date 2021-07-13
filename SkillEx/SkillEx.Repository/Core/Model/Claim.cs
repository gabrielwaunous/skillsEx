using System;
using System.Collections.Generic;
using System.Text;

namespace SkillEx.Repository.Core.Model
{
    public class Claim
    {
        public Claim(ClaimDTO ClaimString)
        {
            Type = (ClaimType)Enum.Parse(typeof(ClaimType), ClaimString.Type);
            DOI = DateTime.Parse(ClaimString.DOI);
            Number = ClaimString.Number;
            Claimant = new Claimant(ClaimString.Claimant);

        }

        public ClaimType Type { get; set; }
        public DateTime DOI { get; set; }
        public string Number { get; set; }
        public Claimant Claimant { get; set; }
    }
}
