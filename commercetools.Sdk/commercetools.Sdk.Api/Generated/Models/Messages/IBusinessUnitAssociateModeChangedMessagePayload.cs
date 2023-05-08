using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateModeChangedMessagePayload))]
    public partial interface IBusinessUnitAssociateModeChangedMessagePayload : IMessagePayload
    {
        IBusinessUnitAssociateMode AssociateMode { get; set; }

        IBusinessUnitAssociateMode OldAssociateMode { get; set; }

    }
}
