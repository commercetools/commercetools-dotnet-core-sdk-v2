using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleBuyerAssignableChangedMessagePayload))]
    public partial interface IAssociateRoleBuyerAssignableChangedMessagePayload : IMessagePayload
    {
        bool BuyerAssignable { get; set; }

    }
}
