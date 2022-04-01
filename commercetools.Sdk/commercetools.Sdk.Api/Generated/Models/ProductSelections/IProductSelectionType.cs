using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionType))]
    [SubTypeDiscriminator("individual", typeof(commercetools.Sdk.Api.Models.ProductSelections.IndividualProductSelectionType))]
    public partial interface IProductSelectionType
    {
        IProductSelectionTypeEnum Type { get; set; }
    }
}
