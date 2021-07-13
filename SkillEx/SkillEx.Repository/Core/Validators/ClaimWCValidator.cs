using SkillEx.Repository.Core.Interfaces;
using SkillEx.Repository.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SkillEx.Repository.Core.Validators
{
    public class ClaimWCValidator : Validator
    {
        private static readonly string CtypeWCPrefix = "WC";

        public ClaimWCValidator(ILogger logger, ClaimDTO ClaimString) : base(logger, ClaimString)
        {
        }

        public override ClaimDTO Validate(ClaimDTO ClaimSource)
        {
            string value = Regex.Match(ClaimSource.Number, @"^.{0,2}").ToString();
            if (value != CtypeWCPrefix) ClaimSource.Number = CtypeWCPrefix + ClaimSource.Number;
            return ClaimSource;
        }
    }
}
