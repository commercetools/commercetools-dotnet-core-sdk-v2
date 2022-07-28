using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddAddressChange))]
    public partial interface IAddAddressChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAddress NextValue { get; set; }

        IAddress PreviousValue { get; set; }

    }
}
