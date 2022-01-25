using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.IndividualProductSelectionType))]
    public partial interface IIndividualProductSelectionType : IProductSelectionType
    {
        ILocalizedString Name { get; set; }
    }
}
