using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class LocalizableTextSetAttribute : ILocalizableTextSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IList<ILocalizedString> Value { get; set; }

        public IEnumerable<ILocalizedString> ValueEnumerable { set => Value = value.ToList(); }
        public LocalizableTextSetAttribute()
        {
            this.Type = "ltext-set";
        }
    }
}
