using infra;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tvpSection")]
	public class TvpSection
	{		
		[XmlAttribute]
		private string? id;
		[XmlAttribute(AttributeName = "id")]
		public string Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id != null ? this.id : "";   
            }
        
        }		
		[XmlAttribute]
		private string? name;
		[XmlAttribute(AttributeName = "name")]
		public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name != null ? this.name : "";   
            }
        
        }		
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeSection>? trackSections;
        [XmlArrayItem("trainDetector", Namespace = "https://erju.org/infra")]
        public List<TrainDetectorRef>? trainDetectors;
	}
}