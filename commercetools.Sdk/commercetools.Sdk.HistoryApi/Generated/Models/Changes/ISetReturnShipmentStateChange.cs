using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReturnShipmentStateChange))]
    public partial interface ISetReturnShipmentStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IReturnShipmentState PreviousValue { get; set; }

        IReturnShipmentState NextValue { get; set; }

    }
}
