

namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class LocalizableEnumAttribute : ILocalizableEnumAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }
        public LocalizableEnumAttribute()
        {
            this.Type = "lenum";
        }
    }
}
