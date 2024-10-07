using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeNameAction))]
    public partial interface IProductTypeChangeAttributeNameAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        string NewAttributeName { get; set; }

    }
}
