using commercetools.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.ProductSelectionSetting))]
    public partial interface IProductSelectionSetting
    {
        IProductSelectionReference ProductSelection { get; set; }

        bool Active { get; set; }
    }
}
