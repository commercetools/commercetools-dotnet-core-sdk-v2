using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Labels.CustomerLabel))]
    public partial interface ICustomerLabel : ILabel
    {
        new string Type { get; set;}
        
        string FirstName { get; set;}
        
        string LastName { get; set;}
        
        string CustomerNumber { get; set;}
    }
}
