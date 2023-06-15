using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDefaultShippingAddressChange))]
    public partial interface ISetDefaultShippingAddressChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAddress PreviousValue { get; set; }

        IAddress NextValue { get; set; }

    }
}
