using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderStateTransitionMessagePayload))]
    public partial interface IOrderStateTransitionMessagePayload : IMessagePayload
    {
        IStateReference State { get; set;}
        
        IStateReference OldState { get; set;}
        
        bool Force { get; set;}
    }
}
