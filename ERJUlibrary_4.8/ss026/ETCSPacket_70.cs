using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_70")]
	public class ETCSPacket_70
	{
		[XmlArrayItem("routeSuitability", Namespace = "https://erju.org/ss026")]
		public List<RouteSuitability> routeSuitabilities;
		[XmlAttribute]
		public uint d_trackinit;

	}
}
