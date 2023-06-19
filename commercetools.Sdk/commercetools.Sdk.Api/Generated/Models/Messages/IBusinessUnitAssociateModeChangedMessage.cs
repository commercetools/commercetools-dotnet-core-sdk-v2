using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociateModeChangedMessage))]
    public partial interface IBusinessUnitAssociateModeChangedMessage : IMessage
    {
        IBusinessUnitAssociateMode AssociateMode { get; set; }

        IBusinessUnitAssociateMode OldAssociateMode { get; set; }

    }
}
