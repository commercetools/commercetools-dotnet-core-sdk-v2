using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeIsSearchableAction))]
    public partial interface IProductTypeChangeIsSearchableAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        bool IsSearchable { get; set; }

    }
}
