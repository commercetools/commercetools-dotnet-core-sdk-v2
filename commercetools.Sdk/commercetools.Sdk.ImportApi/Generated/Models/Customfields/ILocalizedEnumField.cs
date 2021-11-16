using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.LocalizedEnumField))]
    public partial interface ILocalizedEnumField : ICustomField
    {
        string Value { get; set; }
    }
}
