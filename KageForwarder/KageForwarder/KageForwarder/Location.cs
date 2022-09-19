using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KageForwarder
{
	[DataContract]
	internal class Location
	{
		public string ip { get; set; }
		public string country_name { get; set; }
	
    }
}
