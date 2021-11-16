using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.CustomShippingMethodChangeValue))]
    public partial interface ICustomShippingMethodChangeValue 
    {
        string Name { get; set;}
    }
}
