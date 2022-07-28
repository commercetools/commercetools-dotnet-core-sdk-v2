using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueOrderAction))]
    public partial interface IProductTypeChangePlainEnumValueOrderAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        List<IAttributePlainEnumValue> Values { get; set; }

    }
}
