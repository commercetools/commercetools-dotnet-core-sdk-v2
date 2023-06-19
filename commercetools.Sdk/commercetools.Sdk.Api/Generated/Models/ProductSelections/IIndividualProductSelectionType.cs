using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.IndividualProductSelectionType))]
    public partial interface IIndividualProductSelectionType : IProductSelectionType
    {
        ILocalizedString Name { get; set; }

    }
}
