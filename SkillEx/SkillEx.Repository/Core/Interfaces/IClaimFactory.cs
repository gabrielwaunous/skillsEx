using SkillEx.Repository.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillEx.Repository.Core.Interfaces
{
    public interface IClaimFactory
    {
        void ClaimProcessor(IEnumerable<ClaimDTO> ListOfClaims);
    }
}
