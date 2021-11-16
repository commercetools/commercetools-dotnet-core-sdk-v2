using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeAttributeConstraintAction))]
    public partial interface IProductTypeChangeAttributeConstraintAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IAttributeConstraintEnumDraft NewValue { get; set; }
    }
}
