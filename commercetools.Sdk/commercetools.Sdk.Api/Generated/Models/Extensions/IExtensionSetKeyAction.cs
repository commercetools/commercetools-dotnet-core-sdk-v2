using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionSetKeyAction))]
    public partial interface IExtensionSetKeyAction : IExtensionUpdateAction
    {
        string Key { get; set; }
    }
}
