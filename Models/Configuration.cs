using System.Xml.Serialization;

namespace ConfigurationReader.Models
{
    [XmlRoot(ElementName = "config", IsNullable = false )]
    public class Configuration
    {
        [XmlElement(ElementName = "name", IsNullable = false)]
        public string Name { get; set; }

        [XmlElement(ElementName = "description", IsNullable = false)]
        public string Description {  get; set; }
    }
}
