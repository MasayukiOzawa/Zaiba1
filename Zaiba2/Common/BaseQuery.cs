using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zaiba2.Common
{
    [XmlRoot("BaseQuery")]
    public class XMLBaseQuery
    {
        [XmlElement("Query")]
        public List<Query> Query { get; set; }
    }
    public class Query
    {
        [XmlElement("index")]
        public int index { get; set; }
        [XmlElement("name")]
        public string name { get; set; }
        [XmlElement("sql")]
        public string sql { get; set; }

    }
}
