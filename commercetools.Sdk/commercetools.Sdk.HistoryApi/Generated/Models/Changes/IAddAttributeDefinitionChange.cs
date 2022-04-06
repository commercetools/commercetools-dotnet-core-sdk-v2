using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddAttributeDefinitionChange))]
    public partial interface IAddAttributeDefinitionChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAttributeDefinition NextValue { get; set; }
    }
}
