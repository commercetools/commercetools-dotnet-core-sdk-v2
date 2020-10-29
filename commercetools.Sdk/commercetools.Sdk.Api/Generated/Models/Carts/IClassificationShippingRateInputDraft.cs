using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.ClassificationShippingRateInputDraft))]
    public interface IClassificationShippingRateInputDraft : IShippingRateInputDraft
    {
        string Key { get; set;}
    }
}
