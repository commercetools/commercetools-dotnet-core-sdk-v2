using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCreatedMessagePayload))]
    public partial interface IBusinessUnitCreatedMessagePayload : IMessagePayload
    {
        IBusinessUnit BusinessUnit { get; set; }

    }
}
