using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitContactEmailSetMessage))]
    public partial interface IBusinessUnitContactEmailSetMessage : IMessage
    {
        string ContactEmail { get; set; }

    }
}
