using commercetools.Api.Models.OrderEdits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderEditAppliedMessage))]
    public partial interface IOrderEditAppliedMessage : IMessage
    {
        IOrderEditReference Edit { get; set;}
        
        IOrderEditApplied Result { get; set;}
    }
}
