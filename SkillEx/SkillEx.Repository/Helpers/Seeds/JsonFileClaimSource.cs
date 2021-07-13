using SkillEx.Repository.Core.Interfaces;
using System.IO;

namespace SkillEx.Repository.Helpers.Seeds
{
    public class JsonFileClaimSource : IClaimsSource
    {
        public string GetClaimsFromSource() => File.ReadAllText("ClaimsSource.json");
    }
}
