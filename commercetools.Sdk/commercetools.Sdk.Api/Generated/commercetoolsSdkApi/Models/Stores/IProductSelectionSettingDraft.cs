using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.ProductSelectionSettingDraft))]
    public partial interface IProductSelectionSettingDraft
    {
        IProductSelectionResourceIdentifier ProductSelection { get; set; }

        bool? Active { get; set; }

    }
}
