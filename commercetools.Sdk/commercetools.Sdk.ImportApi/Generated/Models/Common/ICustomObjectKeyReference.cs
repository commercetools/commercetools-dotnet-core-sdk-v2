using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.CustomObjectKeyReference))]
    public partial interface ICustomObjectKeyReference : IKeyReference
    {
        string Container { get; set;}
    }
}
