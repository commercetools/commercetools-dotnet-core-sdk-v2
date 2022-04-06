using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Location))]
    public partial interface ILocation
    {
        string Country { get; set; }

        string State { get; set; }
    }
}
