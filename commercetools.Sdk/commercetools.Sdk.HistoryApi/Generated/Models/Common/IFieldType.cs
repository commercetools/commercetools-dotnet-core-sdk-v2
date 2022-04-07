using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.FieldType))]
    public partial interface IFieldType
    {
        string Name { get; set; }
    }
}
