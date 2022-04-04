using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValuesError))]
    public partial interface IDuplicateAttributeValuesError : IErrorObject
    {
        List<IAttribute> Attributes { get; set; }
    }
}
