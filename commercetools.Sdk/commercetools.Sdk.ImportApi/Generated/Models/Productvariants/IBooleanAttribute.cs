using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.BooleanAttribute))]
    public partial interface IBooleanAttribute : IAttribute
    {
        bool Value { get; set;}
    }
}
