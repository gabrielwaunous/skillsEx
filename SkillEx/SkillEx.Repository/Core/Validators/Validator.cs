using SkillEx.Repository.Core.Interfaces;
using SkillEx.Repository.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillEx.Repository.Core.Validators
{
    public abstract class Validator
    {
        public ILogger Logger { get; set; }
        public Claim Claim { get; set; }

        public Validator(ILogger logger, ClaimDTO ClaimString)
        {
            Logger = logger;
            ClaimString = Validate(ClaimString);
            Claim = new Claim(ClaimString);
            Claim.DOI = ClaimDOIValidation(Claim);

        }

        public abstract ClaimDTO Validate(ClaimDTO ClaimSource);

        protected DateTime ClaimDOIValidation(Claim Claim) => Claim.DOI = Claim.DOI.AddMonths(-1);
    }
}
