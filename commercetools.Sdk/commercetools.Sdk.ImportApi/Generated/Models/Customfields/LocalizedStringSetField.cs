using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class LocalizedStringSetField : ILocalizedStringSetField
    {
        public string Type { get; set; }

        public IList<ILocalizedString> Value { get; set; }
        public IEnumerable<ILocalizedString> ValueEnumerable { set => Value = value.ToList(); }

        public LocalizedStringSetField()
        {
            this.Type = "LocalizedStringSet";
        }
    }
}
