using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class AttributeCoverage : IAttributeCoverage
    {
        public double Names { get; set; }

        public double Values { get; set; }
    }
}
