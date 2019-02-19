//-----------------------------------------------------------------------
// <copyright file="json2xmltests.cs" company="McGowans Print">
//      Copyright (c) McGowans Print. All rights reserved.
//      Licensed under the Apache License, Version 2.0. See LICENSE in
//      the project root for license information.
// </copyright>
// <author>Michael McMullin</author>
//-----------------------------------------------------------------------
namespace J2XTests
{
    using System;
    using System.Xml.Linq;
    using J2XLib;
    using Xunit;

    /// <summary>
    /// Unit tests for converting JSON data to XML.
    /// </summary>
    public class Json2XmlTests
    {
        private static readonly string TestJson1 = "[{\"code\":\"AT\", \"name\":\"Austria\", \"eu\":true},{\"code\":\"BE\",\"name\":\"Belgium\",\"eu\":true},{\"code\":\"CY\",\"name\":\"Cyprus\",\"eu\":true},{\"code\":\"CZ\",\"name\":\"Czech Republic\",\"eu\":true},{\"code\":\"DK\",\"name\":\"Denmark\",\"eu\":true},{\"code\":\"EE\",\"name\":\"Estonia\",\"eu\":true},{\"code\":\"FI\",\"name\":\"Finland\",\"eu\":true},{\"code\":\"FR\",\"name\":\"France\",\"eu\":true},{\"code\":\"DE\",\"name\":\"Germany\",\"eu\":true},{\"code\":\"GR\",\"name\":\"Greece\",\"eu\":true},{\"code\":\"HU\",\"name\":\"Hungary\",\"eu\":true},{\"code\":\"IT\",\"name\":\"Italy\",\"eu\":true},{\"code\":\"LV\",\"name\":\"Latvia\",\"eu\":true},{\"code\":\"LT\",\"name\":\"Lithuania\",\"eu\":true},{\"code\":\"LU\",\"name\":\"Luxembourg\",\"eu\":true},{\"code\":\"MT\",\"name\":\"Malta\",\"eu\":true},{\"code\":\"NL\",\"name\":\"Netherlands\",\"eu\":true},{\"code\":\"PL\",\"name\":\"Poland\",\"eu\":true},{\"code\":\"PT\",\"name\":\"Portugal\",\"eu\":true},{\"code\":\"IE\",\"name\":\"Republic of Ireland\",\"eu\":true},{\"code\":\"SC\",\"name\":\"Scotland\",\"eu\":true},{\"code\":\"SK\",\"name\":\"Slovakia\",\"eu\":true},{\"code\":\"SI\",\"name\":\"Slovenia\",\"eu\":true},{\"code\":\"SA\",\"name\":\"South Africa\",\"eu\":true},{\"code\":\"ES\",\"name\":\"Spain\",\"eu\":true},{\"code\":\"SE\",\"name\":\"Sweden\",\"eu\":true},{\"code\":\"GB\",\"name\":\"United Kingdom\",\"eu\":true}]";
        private static readonly string TestJson2 = "{\"code\":\"AT\",\"name\":\"Austria\",\"eu\":true,\"priority\":3}";
        private static readonly string TestJson3 = "{\"job\":\"123456\",\"items\":[{\"name\":\"Widget 1\",\"qty\":5},{\"name\":\"Widget 2\",\"qty\":3}]}";
        private static readonly string TestJson4 = "{\"job\":\"123456\",\"items\":[{\"name\":\"Widget 1\",\"qty\":\"5\",\"colours\":[{\"name\":\"Red\"}, {\"name\":\"Green\"}, {\"name\":\"Blue\"}]},{\"name\":\"Widget 2\",\"qty\":3,\"colours\":[{\"name\":\"Red\"}, {\"name\":\"Green\"}, {\"name\":\"Blue\"}]}]}";
        private static readonly string TestJson5 = "{\"job\":\"123456\",\"items\":[{\"name\":\"Widget 1\",\"qty\":\"5\",\"colours\":[\"Red\", \"Green\", \"Blue\"]},{\"name\":\"Widget 2\",\"qty\":3,\"colours\":[\"Red\", \"Green\", \"Blue\"]}]}";

        /// <summary>
        /// Ensure that valid JSON data converts to a non-null value.
        /// </summary>
        [Fact]
        public void TestNotNull()
        {
            XNode node = Json2Xml.Convert(TestJson1);
            Assert.NotNull(node);
        }
    }
}
