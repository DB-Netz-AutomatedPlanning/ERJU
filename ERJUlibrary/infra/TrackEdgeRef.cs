using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdge")]
	public class TrackEdgeRef
	{
		private string _ref;
		[XmlAttribute(AttributeName = "ref")]
		public string Ref
		{
			set
			{
				this._ref = value;
			}
			get
			{
				return this._ref != null?  this._ref : "";
			}
		}

	}

}
