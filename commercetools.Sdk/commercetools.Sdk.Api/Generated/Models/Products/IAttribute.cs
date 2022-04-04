using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.Attribute))]
    public partial interface IAttribute
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
