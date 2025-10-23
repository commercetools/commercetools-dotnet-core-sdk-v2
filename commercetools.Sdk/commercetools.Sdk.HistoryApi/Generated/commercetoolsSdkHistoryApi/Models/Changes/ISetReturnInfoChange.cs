using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReturnInfoChange))]
    public partial interface ISetReturnInfoChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IReturnInfo PreviousValue { get; set; }

        IReturnInfo NextValue { get; set; }

    }
}
