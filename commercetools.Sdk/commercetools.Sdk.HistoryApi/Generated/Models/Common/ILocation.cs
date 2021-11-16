using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.Location))]
    public partial interface ILocation
    {
        string Country { get; set; }

        string State { get; set; }
    }
}
