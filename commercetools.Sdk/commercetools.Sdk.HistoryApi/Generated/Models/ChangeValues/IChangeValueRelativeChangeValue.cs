using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueRelativeChangeValue))]
    public partial interface IChangeValueRelativeChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set;}
        
        int Permyriad { get; set;}
    }
}
