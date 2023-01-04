using System.Xml.Serialization;
using Tasks.Entities.Vehicles;

namespace Tasks;

public static class Serializer
{
    public static string ToXML(Vehicle vehicle)
    {
        using(var stringWriter = new StringWriter())
        { 
            var serializer = new XmlSerializer(vehicle.GetType());
            serializer.Serialize(stringWriter, vehicle);
            return stringWriter.ToString();
        }
    }
    
    public static void GetXmlString(List<Vehicle> vehicles)
    {
        List<string> xmlStringList = new List<string>();
        foreach (var veh in vehicles)
        {
            xmlStringList.Add(ToXML(veh));
        }

        foreach (var xml in xmlStringList)
        {
            Console.WriteLine(xml + "\n");
        }
    }
}