using SkillEx.Repository.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillEx.Repository.Core.Interfaces
{
    public interface IImportProcess
    {
        void SaveClaim(ILogger Logger, Claim Claim);
    }
}
