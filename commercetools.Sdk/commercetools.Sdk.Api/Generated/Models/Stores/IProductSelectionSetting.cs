using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.ProductSelectionSetting))]
    public partial interface IProductSelectionSetting
    {
        IProductSelectionReference ProductSelection { get; set; }

        bool Active { get; set; }

    }
}
