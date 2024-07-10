using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class LocalizedEnumValue : ILocalizedEnumValue
    {
        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
