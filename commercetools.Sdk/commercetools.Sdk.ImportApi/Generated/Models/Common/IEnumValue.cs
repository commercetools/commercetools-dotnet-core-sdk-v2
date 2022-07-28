using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.EnumValue))]
    public partial interface IEnumValue
    {
        string Key { get; set; }

        string Label { get; set; }

    }
}
