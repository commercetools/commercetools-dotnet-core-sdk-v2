using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTopLevelUnitChange))]
    public partial interface IChangeTopLevelUnitChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IKeyReference PreviousValue { get; set; }

        IKeyReference NextValue { get; set; }

    }
}
