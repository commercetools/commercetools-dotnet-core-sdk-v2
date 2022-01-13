using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeDescriptionAction))]
    public partial interface IProductTypeChangeDescriptionAction : IProductTypeUpdateAction
    {
        string Description { get; set; }
    }
}
