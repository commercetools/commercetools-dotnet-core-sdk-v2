using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.CustomObjectKeyReference))]
    public partial interface ICustomObjectKeyReference : IKeyReference
    {
        string Container { get; set; }

    }
}
