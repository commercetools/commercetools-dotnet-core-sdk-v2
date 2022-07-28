using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.StringField))]
    public partial interface IStringField : ICustomField
    {
        string Value { get; set; }

    }
}
