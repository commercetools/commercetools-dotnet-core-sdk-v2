using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductStateTransitionMessage))]
    public partial interface IProductStateTransitionMessage : IMessage
    {
        IStateReference State { get; set;}
        
        bool Force { get; set;}
    }
}
