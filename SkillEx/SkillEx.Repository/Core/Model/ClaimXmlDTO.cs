using System;
using System.Collections.Generic;
using System.Text;

namespace SkillEx.Repository.Core.Model
{
    [Serializable()]
    public class ClaimXmlDTO
    {
        [System.Xml.Serialization.XmlElement("Type")]
        string Type { get; set; }
        [System.Xml.Serialization.XmlElement("DOI")]
        string DOI { get; set; }
        [System.Xml.Serialization.XmlElement("Number")]
        string Number { get; set; }
        [System.Xml.Serialization.XmlElement("Claimant")]
        string Claimant { get; set; }
    }
}
