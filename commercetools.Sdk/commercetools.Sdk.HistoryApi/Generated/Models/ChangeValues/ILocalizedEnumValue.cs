using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.LocalizedEnumValue))]
    public partial interface ILocalizedEnumValue 
    {
        string Key { get; set;}
        
        ILocalizedString Label { get; set;}
    }
}
