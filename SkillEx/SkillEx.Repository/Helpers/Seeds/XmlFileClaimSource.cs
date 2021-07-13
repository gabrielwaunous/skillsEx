using SkillEx.Repository.Core.Interfaces;
using System.IO;

namespace SkillEx.Repository.Helpers.Seeds
{
    public class XmlFileClaimSource : IClaimsSource
    {
        public string GetClaimsFromSource() => File.ReadAllText("ClaimSource.xml");
    }
}

