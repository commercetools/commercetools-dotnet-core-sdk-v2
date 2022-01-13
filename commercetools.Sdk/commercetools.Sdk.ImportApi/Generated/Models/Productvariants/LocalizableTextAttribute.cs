using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Productvariants
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
