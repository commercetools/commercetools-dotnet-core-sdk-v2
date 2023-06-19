using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCreatedMessage))]
    public partial interface IBusinessUnitCreatedMessage : IMessage
    {
        IBusinessUnit BusinessUnit { get; set; }

    }
}
