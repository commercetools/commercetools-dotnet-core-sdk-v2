using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateRemovedMessagePayload))]
    public partial interface IBusinessUnitAssociateRemovedMessagePayload : IMessagePayload
    {
        IAssociate Associate { get; set; }

    }
}
