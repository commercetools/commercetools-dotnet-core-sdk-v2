using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderAction))]
    public partial interface IProductTypeChangeAttributeOrderAction : IProductTypeUpdateAction
    {
        List<IAttributeDefinition> Attributes { get; set; }
    }
}
