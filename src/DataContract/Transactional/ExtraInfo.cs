using System.Collections.Generic;
using System.Xml.Serialization;

namespace MaxiPago.DataContract.Transactional;

[XmlRoot(ElementName = "extraInfo")]
public class ExtraInfo
{

    [XmlElement(ElementName = "info")]
    public List<Info> Info { get; set; }
}
