using System;
using System.Xml.Linq;
using Xunit;
using j2xlib;

namespace j2xtests
{
    public class testjson2xml
    {
		public static String test1 = "[{\"code\":\"AT\", \"name\":\"Austria\", \"eu\":true},{\"code\":\"BE\",\"name\":\"Belgium\",\"eu\":true},{\"code\":\"CY\",\"name\":\"Cyprus\",\"eu\":true},{\"code\":\"CZ\",\"name\":\"Czech Republic\",\"eu\":true},{\"code\":\"DK\",\"name\":\"Denmark\",\"eu\":true},{\"code\":\"EE\",\"name\":\"Estonia\",\"eu\":true},{\"code\":\"FI\",\"name\":\"Finland\",\"eu\":true},{\"code\":\"FR\",\"name\":\"France\",\"eu\":true},{\"code\":\"DE\",\"name\":\"Germany\",\"eu\":true},{\"code\":\"GR\",\"name\":\"Greece\",\"eu\":true},{\"code\":\"HU\",\"name\":\"Hungary\",\"eu\":true},{\"code\":\"IT\",\"name\":\"Italy\",\"eu\":true},{\"code\":\"LV\",\"name\":\"Latvia\",\"eu\":true},{\"code\":\"LT\",\"name\":\"Lithuania\",\"eu\":true},{\"code\":\"LU\",\"name\":\"Luxembourg\",\"eu\":true},{\"code\":\"MT\",\"name\":\"Malta\",\"eu\":true},{\"code\":\"NL\",\"name\":\"Netherlands\",\"eu\":true},{\"code\":\"PL\",\"name\":\"Poland\",\"eu\":true},{\"code\":\"PT\",\"name\":\"Portugal\",\"eu\":true},{\"code\":\"IE\",\"name\":\"Republic of Ireland\",\"eu\":true},{\"code\":\"SC\",\"name\":\"Scotland\",\"eu\":true},{\"code\":\"SK\",\"name\":\"Slovakia\",\"eu\":true},{\"code\":\"SI\",\"name\":\"Slovenia\",\"eu\":true},{\"code\":\"SA\",\"name\":\"South Africa\",\"eu\":true},{\"code\":\"ES\",\"name\":\"Spain\",\"eu\":true},{\"code\":\"SE\",\"name\":\"Sweden\",\"eu\":true},{\"code\":\"GB\",\"name\":\"United Kingdom\",\"eu\":true}]";
		public static String test2 = "{\"code\":\"AT\",\"name\":\"Austria\",\"eu\":true,\"priority\":3}";
		public static String test3 = "{\"job\":\"123456\",\"items\":[{\"name\":\"Widget 1\",\"qty\":5},{\"name\":\"Widget 2\",\"qty\":3}]}";
		public static String test4 = "{\"job\":\"123456\",\"items\":[{\"name\":\"Widget 1\",\"qty\":\"5\",\"colours\":[{\"name\":\"Red\"}, {\"name\":\"Green\"}, {\"name\":\"Blue\"}]},{\"name\":\"Widget 2\",\"qty\":3,\"colours\":[{\"name\":\"Red\"}, {\"name\":\"Green\"}, {\"name\":\"Blue\"}]}]}";
		public static String test5 = "{\"job\":\"123456\",\"items\":[{\"name\":\"Widget 1\",\"qty\":\"5\",\"colours\":[\"Red\", \"Green\", \"Blue\"]},{\"name\":\"Widget 2\",\"qty\":3,\"colours\":[\"Red\", \"Green\", \"Blue\"]}]}";

		[Fact]
        public void TestNotNull()
        {
			XNode node = json2xml.Convert(test1);
			Assert.NotNull(node);
        }
    }
}
