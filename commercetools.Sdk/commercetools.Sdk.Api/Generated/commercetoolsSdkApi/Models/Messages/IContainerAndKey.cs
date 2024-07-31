using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ContainerAndKey))]
    public partial interface IContainerAndKey
    {
        string Key { get; set; }

        string Container { get; set; }

    }
}
