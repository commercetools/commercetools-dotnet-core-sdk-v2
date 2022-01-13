using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeIsSearchableAction))]
    public partial interface IProductTypeChangeIsSearchableAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        bool IsSearchable { get; set; }
    }
}
