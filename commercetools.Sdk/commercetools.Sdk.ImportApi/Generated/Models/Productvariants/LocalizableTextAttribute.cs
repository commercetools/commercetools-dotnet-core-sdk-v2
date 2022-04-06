using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    public partial class LocalizableTextAttribute : ILocalizableTextAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public ILocalizedString Value { get; set; }
        public LocalizableTextAttribute()
        {
            this.Type = "ltext";
        }
    }
}
