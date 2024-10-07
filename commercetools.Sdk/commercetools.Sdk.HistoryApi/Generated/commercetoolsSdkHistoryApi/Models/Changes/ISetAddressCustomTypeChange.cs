using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAddressCustomTypeChange))]
    public partial interface ISetAddressCustomTypeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAddress Address { get; set; }

        ICustomFields PreviousValue { get; set; }

        ICustomFields NextValue { get; set; }

    }
}
