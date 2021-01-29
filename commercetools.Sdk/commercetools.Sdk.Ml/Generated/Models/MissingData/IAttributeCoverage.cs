using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.AttributeCoverage))]
    public partial interface IAttributeCoverage 
    {
        double Names { get; set;}
        
        double Values { get; set;}
    }
}
