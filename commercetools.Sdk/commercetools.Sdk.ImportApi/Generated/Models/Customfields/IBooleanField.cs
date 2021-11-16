using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.BooleanField))]
    public partial interface IBooleanField : ICustomField
    {
        bool Value { get; set;}
    }
}
