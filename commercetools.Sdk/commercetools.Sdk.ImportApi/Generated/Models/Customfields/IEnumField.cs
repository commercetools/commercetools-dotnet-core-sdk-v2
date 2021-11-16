using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.EnumField))]
    public partial interface IEnumField : ICustomField
    {
        string Value { get; set; }
    }
}
