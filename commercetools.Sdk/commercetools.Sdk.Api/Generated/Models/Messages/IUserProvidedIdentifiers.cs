using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.UserProvidedIdentifiers))]
    public partial interface IUserProvidedIdentifiers
    {
        string Key { get; set; }

        string ExternalId { get; set; }

        string OrderNumber { get; set; }

        string CustomerNumber { get; set; }

        string Sku { get; set; }

        ILocalizedString Slug { get; set; }

        IContainerAndKey ContainerAndKey { get; set; }

    }
}
