using System.Xml.Serialization;

namespace Tasks.Entities;

public class Chassis
{
    [XmlAttribute("WheelsNumber")]
    public int WheelsNumber { get; set; }
    
    [XmlAttribute("Number")]
    public int Number { get; set; }
    
    [XmlAttribute("PermissibleLoad")]
    public int PermissibleLoad { get; set; }
}