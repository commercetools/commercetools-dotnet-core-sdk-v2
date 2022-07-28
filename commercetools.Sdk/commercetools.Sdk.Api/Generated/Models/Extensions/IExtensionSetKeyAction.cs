using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetKeyAction))]
    public partial interface IExtensionSetKeyAction : IExtensionUpdateAction
    {
        string Key { get; set; }

    }
}
