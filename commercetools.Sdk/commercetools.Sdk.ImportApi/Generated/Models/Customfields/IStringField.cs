using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.StringField))]
    public partial interface IStringField : ICustomField
    {
        string Value { get; set; }
    }
}
