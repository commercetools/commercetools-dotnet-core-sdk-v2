using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.AttributeCoverage))]
    public partial interface IAttributeCoverage
    {
        double Names { get; set; }

        double Values { get; set; }
    }
}
