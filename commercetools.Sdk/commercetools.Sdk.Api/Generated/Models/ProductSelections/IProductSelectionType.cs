using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionType))]
    [SubTypeDiscriminator("individual", typeof(commercetools.Api.Models.ProductSelections.IndividualProductSelectionType))]
    public partial interface IProductSelectionType
    {
        IProductSelectionTypeEnum Type { get; set; }
    }
}
