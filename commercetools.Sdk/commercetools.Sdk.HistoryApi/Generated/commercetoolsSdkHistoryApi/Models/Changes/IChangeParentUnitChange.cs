using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeParentUnitChange))]
    public partial interface IChangeParentUnitChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IKeyReference PreviousValue { get; set; }

        IKeyReference NextValue { get; set; }

    }
}
