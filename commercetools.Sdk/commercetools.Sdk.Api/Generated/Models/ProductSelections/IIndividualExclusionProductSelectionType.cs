using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.IndividualExclusionProductSelectionType))]
    public partial interface IIndividualExclusionProductSelectionType : IProductSelectionType
    {
        ILocalizedString Name { get; set; }

    }
}
