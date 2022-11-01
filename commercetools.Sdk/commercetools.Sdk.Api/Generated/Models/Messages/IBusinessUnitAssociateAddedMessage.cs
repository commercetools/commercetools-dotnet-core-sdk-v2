using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateAddedMessage))]
    public partial interface IBusinessUnitAssociateAddedMessage : IMessage
    {
        IAssociate Associate { get; set; }

    }
}
