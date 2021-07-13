using SkillEx.Repository.Core.Interfaces;
using SkillEx.Repository.Core.Model;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SkillEx.Repository.Helpers.Serializers
{
    public class XmlClaimSerializer : IClaimSerializer
    {
        public IEnumerable<ClaimDTO> GetClaimFromString(string claimString)
        {

            ClaimList claimList = null;
            XmlSerializer serializer = new XmlSerializer(typeof(ClaimList));

            StreamReader reader = new StreamReader(@"ClaimSource.xml");
            claimList = (ClaimList)serializer.Deserialize(reader);
            reader.Close();

            return (IEnumerable<ClaimDTO>)claimList;

        }
    }
}
