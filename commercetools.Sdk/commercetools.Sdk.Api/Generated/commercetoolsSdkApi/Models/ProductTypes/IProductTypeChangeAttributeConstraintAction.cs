using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeConstraintAction))]
    public partial interface IProductTypeChangeAttributeConstraintAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IAttributeConstraintEnumDraft NewValue { get; set; }

    }
}
