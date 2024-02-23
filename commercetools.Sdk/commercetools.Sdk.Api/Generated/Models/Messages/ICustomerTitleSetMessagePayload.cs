using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessagePayload))]
    public partial interface ICustomerTitleSetMessagePayload : IMessagePayload
    {
        string Title { get; set; }

    }
}
