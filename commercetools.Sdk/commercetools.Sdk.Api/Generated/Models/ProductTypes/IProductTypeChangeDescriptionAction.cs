using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeDescriptionAction))]
    public partial interface IProductTypeChangeDescriptionAction : IProductTypeUpdateAction
    {
        string Description { get; set; }

    }
}
