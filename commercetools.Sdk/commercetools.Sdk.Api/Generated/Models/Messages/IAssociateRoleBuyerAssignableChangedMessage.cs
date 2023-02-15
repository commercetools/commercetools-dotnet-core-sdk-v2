using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleBuyerAssignableChangedMessage))]
    public partial interface IAssociateRoleBuyerAssignableChangedMessage : IMessage
    {
        bool BuyerAssignable { get; set; }

    }
}
