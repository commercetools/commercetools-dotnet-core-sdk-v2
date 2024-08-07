using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddFieldDefinitionChange))]
    public partial interface IAddFieldDefinitionChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IFieldDefinition NextValue { get; set; }

    }
}
