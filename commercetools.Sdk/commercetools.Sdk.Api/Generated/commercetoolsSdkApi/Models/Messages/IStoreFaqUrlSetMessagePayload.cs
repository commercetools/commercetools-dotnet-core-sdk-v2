using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreFaqUrlSetMessagePayload))]
    public partial interface IStoreFaqUrlSetMessagePayload : IMessagePayload
    {
        string FaqUrl { get; set; }

    }
}
