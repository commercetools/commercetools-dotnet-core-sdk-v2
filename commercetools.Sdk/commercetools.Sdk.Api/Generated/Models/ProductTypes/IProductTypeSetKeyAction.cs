using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeSetKeyAction))]
    public partial interface IProductTypeSetKeyAction : IProductTypeUpdateAction
    {
        string Key { get; set;}
    }
}
