using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeKeyAction))]
    public partial interface ITypeChangeKeyAction : ITypeUpdateAction
    {
        string Key { get; set; }
    }
}
