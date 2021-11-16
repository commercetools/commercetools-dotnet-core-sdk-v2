using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.MessageConfigurationDraft))]
    public partial interface IMessageConfigurationDraft 
    {
        bool Enabled { get; set;}
        
        int DeleteDaysAfterCreation { get; set;}
    }
}
