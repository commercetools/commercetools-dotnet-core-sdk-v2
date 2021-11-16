using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeNameAction))]
    public partial interface IProductTypeChangeNameAction : IProductTypeUpdateAction
    {
        string Name { get; set; }
    }
}
