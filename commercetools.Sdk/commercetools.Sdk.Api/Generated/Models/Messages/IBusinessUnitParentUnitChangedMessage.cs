using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitParentUnitChangedMessage))]
    public partial interface IBusinessUnitParentUnitChangedMessage : IMessage
    {
        IBusinessUnitKeyReference OldParentUnit { get; set; }

        IBusinessUnitKeyReference NewParentUnit { get; set; }

    }
}
