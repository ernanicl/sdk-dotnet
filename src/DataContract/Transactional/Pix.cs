using System.Xml.Serialization;

namespace MaxiPago.DataContract.Transactional;

[XmlRoot(ElementName = "pix")]
public class Pix
{

    [XmlElement(ElementName = "expirationTime")]
    public int ExpirationTime { get; set; }

    [XmlElement(ElementName = "paymentInfo")]
    public string PaymentInfo { get; set; }

    [XmlElement(ElementName = "extraInfo")]
    public ExtraInfo ExtraInfo { get; set; }
}
