using System;
using System.Collections.Generic;
using System.Text;
using SkillEx.Repository.Core.Interfaces;
using SkillEx.Repository.Core.Model;

namespace SkillEx.Repository.Core.Validators
{
    public class UnKnownClaimType : Validator
    {
        public UnKnownClaimType(ILogger logger, ClaimDTO ClaimString) : base(logger, ClaimString)
        {
        }

        public override ClaimDTO Validate(ClaimDTO ClaimSource)
        {
            Logger.Log("UnKnown Claim Type");
            ClaimSource.Type = ClaimType.UnKnown.ToString();
            return ClaimSource;


        }
    }
}
