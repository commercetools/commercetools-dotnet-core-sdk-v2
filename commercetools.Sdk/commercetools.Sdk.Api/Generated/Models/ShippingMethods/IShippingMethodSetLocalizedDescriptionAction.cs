using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodSetLocalizedDescriptionAction))]
    public partial interface IShippingMethodSetLocalizedDescriptionAction : IShippingMethodUpdateAction
    {
        ILocalizedString LocalizedDescription { get; set; }
    }
}
