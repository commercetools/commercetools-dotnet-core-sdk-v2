using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.CustomObjectKeyReference))]
    public partial interface ICustomObjectKeyReference : IKeyReference
    {
        new string Key { get; set; }

        string Container { get; set; }

    }
}
