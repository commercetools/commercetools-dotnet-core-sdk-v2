using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.BooleanField))]
    public partial interface IBooleanField : ICustomField
    {
        bool Value { get; set; }

    }
}
