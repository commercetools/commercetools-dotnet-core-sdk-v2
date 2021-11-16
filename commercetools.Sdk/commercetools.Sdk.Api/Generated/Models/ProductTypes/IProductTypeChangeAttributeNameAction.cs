using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeAttributeNameAction))]
    public partial interface IProductTypeChangeAttributeNameAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        string NewAttributeName { get; set;}
    }
}
