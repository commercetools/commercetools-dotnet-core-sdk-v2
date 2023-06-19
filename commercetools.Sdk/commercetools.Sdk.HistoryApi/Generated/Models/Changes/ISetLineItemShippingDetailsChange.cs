using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemShippingDetailsChange))]
    public partial interface ISetLineItemShippingDetailsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IItemShippingDetails PreviousValue { get; set; }

        IItemShippingDetails NextValue { get; set; }

        string LineItemId { get; set; }

    }
}
