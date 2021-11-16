using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyOrderFromCartDraft))]
    public partial interface IMyOrderFromCartDraft 
    {
        string Id { get; set;}
        
        long Version { get; set;}
    }
}
