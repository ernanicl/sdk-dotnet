using System.Xml.Serialization;

namespace MaxiPago.DataContract.Transactional;

[XmlRoot(ElementName = "info")]
public class Info
{

    [XmlElement(ElementName = "name")]
    public string Name { get; set; }

    [XmlElement(ElementName = "value")]
    public string Value { get; set; }
}
