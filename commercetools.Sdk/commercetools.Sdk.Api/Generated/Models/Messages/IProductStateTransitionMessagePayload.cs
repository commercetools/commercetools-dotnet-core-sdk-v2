using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductStateTransitionMessagePayload))]
    public partial interface IProductStateTransitionMessagePayload : IMessagePayload
    {
        IStateReference State { get; set;}
        
        bool Force { get; set;}
    }
}
