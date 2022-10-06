using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateChangedMessagePayload))]
    public partial interface IBusinessUnitAssociateChangedMessagePayload : IMessagePayload
    {
        IAssociate Associate { get; set; }

    }
}
