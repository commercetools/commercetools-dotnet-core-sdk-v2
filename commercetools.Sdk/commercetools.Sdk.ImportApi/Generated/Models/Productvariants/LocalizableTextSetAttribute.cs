using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class LocalizableTextSetAttribute : ILocalizableTextSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<ILocalizedString> Value { get; set; }
        public LocalizableTextSetAttribute()
        {
            this.Type = "ltext-set";
        }
    }
}
