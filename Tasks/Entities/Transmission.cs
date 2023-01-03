using System.Xml.Serialization;

namespace Tasks.Entities;

public class Transmission
{
    // transmission types can be of manual or automatic
    [XmlAttribute("Type")]
    public string Type { get; set; }
    
    [XmlAttribute("NumberOfGears")]
    public int NumberOfGears { get; set; }
    
    [XmlAttribute("Manufacturer")]
    public string Manufacturer { get; set; }
}