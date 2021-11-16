using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class LocalizedEnumValue : ILocalizedEnumValue
    {
        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
