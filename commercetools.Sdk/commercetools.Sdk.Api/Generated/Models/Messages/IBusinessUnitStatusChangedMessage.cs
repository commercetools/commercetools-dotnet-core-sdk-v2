using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStatusChangedMessage))]
    public partial interface IBusinessUnitStatusChangedMessage : IMessage
    {
        IBusinessUnitStatus Active { get; set; }

    }
}
