using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateChangedMessage))]
    public partial interface IBusinessUnitAssociateChangedMessage : IMessage
    {
        IAssociate Associate { get; set; }

    }
}
