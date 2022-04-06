using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    public partial class LocalizableEnumSetAttribute : ILocalizableEnumSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<string> Value { get; set; }
        public LocalizableEnumSetAttribute()
        {
            this.Type = "lenum-set";
        }
    }
}
