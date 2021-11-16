using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.EnumAttribute))]
    public partial interface IEnumAttribute : IAttribute
    {
        string Value { get; set;}
    }
}
