using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.IndividualProductSelectionType))]
    public partial interface IIndividualProductSelectionType : IProductSelectionType
    {
        ILocalizedString Name { get; set; }

    }
}
