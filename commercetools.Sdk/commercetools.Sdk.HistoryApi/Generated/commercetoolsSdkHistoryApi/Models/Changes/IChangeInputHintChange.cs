using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeInputHintChange))]
    public partial interface IChangeInputHintChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITextInputHint PreviousValue { get; set; }

        ITextInputHint NextValue { get; set; }

        string FieldName { get; set; }

        string AttributeName { get; set; }

    }
}
