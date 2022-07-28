using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetInputTipChange))]
    public partial interface ISetInputTipChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string AttributeName { get; set; }

        ILocalizedString NextValue { get; set; }

        ILocalizedString PreviousValue { get; set; }

    }
}
