using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.TextAttribute))]
    public partial interface ITextAttribute : IAttribute
    {
        string Value { get; set; }
    }
}
