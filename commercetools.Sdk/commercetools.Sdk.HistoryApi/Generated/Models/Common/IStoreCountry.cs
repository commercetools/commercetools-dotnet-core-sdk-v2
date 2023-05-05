using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.StoreCountry))]
    public partial interface IStoreCountry
    {
        string Code { get; set; }

    }
}
