using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitParentUnitChangedMessagePayload))]
    public partial interface IBusinessUnitParentUnitChangedMessagePayload : IMessagePayload
    {
        IBusinessUnitKeyReference OldParentUnit { get; set; }

        IBusinessUnitKeyReference NewParentUnit { get; set; }

    }
}
