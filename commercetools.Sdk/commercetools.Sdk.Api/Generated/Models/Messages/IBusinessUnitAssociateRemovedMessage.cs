using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateRemovedMessage))]
    public partial interface IBusinessUnitAssociateRemovedMessage : IMessage
    {
        IAssociate Associate { get; set; }

    }
}
