using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.FieldDefinitionOrderValue))]
    public partial interface IFieldDefinitionOrderValue 
    {
        string Name { get; set;}
        
        ILocalizedString Label { get; set;}
    }
}
