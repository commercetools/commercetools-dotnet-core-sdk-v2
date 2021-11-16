using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveAttributeDefinitionChange))]
    public partial interface IRemoveAttributeDefinitionChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IAttributeDefinition PreviousValue { get; set;}
    }
}
