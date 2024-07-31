using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeNameAction))]
    public partial interface IProductTypeChangeNameAction : IProductTypeUpdateAction
    {
        string Name { get; set; }

    }
}
