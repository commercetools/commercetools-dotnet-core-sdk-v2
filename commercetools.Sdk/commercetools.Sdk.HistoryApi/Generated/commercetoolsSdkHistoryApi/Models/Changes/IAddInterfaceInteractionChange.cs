using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddInterfaceInteractionChange))]
    public partial interface IAddInterfaceInteractionChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ICustomFields NextValue { get; set; }

    }
}
