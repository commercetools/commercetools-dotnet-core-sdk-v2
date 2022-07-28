using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLabelChange))]
    public partial interface IChangeLabelChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string FieldName { get; set; }

        string AttributeName { get; set; }

        ILocalizedString NextValue { get; set; }

        ILocalizedString PreviousValue { get; set; }

    }
}
