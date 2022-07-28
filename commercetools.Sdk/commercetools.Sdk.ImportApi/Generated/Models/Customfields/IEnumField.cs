using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.EnumField))]
    public partial interface IEnumField : ICustomField
    {
        string Value { get; set; }

    }
}
