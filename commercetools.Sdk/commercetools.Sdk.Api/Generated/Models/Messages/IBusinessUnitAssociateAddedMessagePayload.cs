using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateAddedMessagePayload))]
    public partial interface IBusinessUnitAssociateAddedMessagePayload : IMessagePayload
    {
        IAssociate Associate { get; set; }

    }
}
