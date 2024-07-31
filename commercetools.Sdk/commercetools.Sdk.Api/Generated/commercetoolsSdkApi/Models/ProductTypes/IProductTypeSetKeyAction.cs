using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetKeyAction))]
    public partial interface IProductTypeSetKeyAction : IProductTypeUpdateAction
    {
        string Key { get; set; }

    }
}
