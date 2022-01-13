using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeChangeKeyAction))]
    public partial interface ITypeChangeKeyAction : ITypeUpdateAction
    {
        string Key { get; set; }
    }
}
