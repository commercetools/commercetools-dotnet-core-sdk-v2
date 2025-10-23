using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetPriceModeChange))]
    public partial interface ISetPriceModeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IProductPriceModeEnum PreviousValue { get; set; }

        IProductPriceModeEnum NextValue { get; set; }

    }
}
