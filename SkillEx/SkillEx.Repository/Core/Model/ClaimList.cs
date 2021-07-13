using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SkillEx.Repository.Core.Model
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("ClaimList")]
    public class ClaimList
    {
        [XmlArray("Claim")]
        [XmlArrayItem("Claim", typeof(ClaimXmlDTO))]
        public ClaimXmlDTO[] Claim { get; set; }
    }
}
