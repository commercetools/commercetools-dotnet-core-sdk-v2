using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAddressChange))]
    public partial interface IChangeAddressChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAddress PreviousValue { get; set; }

        IAddress NextValue { get; set; }

    }
}
