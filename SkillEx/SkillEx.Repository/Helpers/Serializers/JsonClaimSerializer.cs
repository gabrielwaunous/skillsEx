using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SkillEx.Repository.Core.Interfaces;
using SkillEx.Repository.Core.Model;
using System.Collections.Generic;

namespace SkillEx.Repository.Helpers.Serializers
{
    public class JsonClaimSerializer : IClaimSerializer
    {
        public IEnumerable<ClaimDTO> GetClaimFromString(string claimString)
        => JsonConvert.DeserializeObject<IEnumerable<ClaimDTO>>(claimString,
            new StringEnumConverter());
    }
}
