using commercetools.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.ProductSelectionSettingDraft))]
    public partial interface IProductSelectionSettingDraft
    {
        IProductSelectionResourceIdentifier ProductSelection { get; set; }

        bool? Active { get; set; }
    }
}
