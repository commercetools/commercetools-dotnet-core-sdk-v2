using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductSelectionSetting))]
    public partial interface IProductSelectionSetting
    {
        IReference ProductSelection { get; set; }

        bool Active { get; set; }
    }
}
