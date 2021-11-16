using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class LocalizedStringSetField : ILocalizedStringSetField
    {
        public string Type { get; set;}
        
        public List<ILocalizedString> Value { get; set;}
        public LocalizedStringSetField()
        { 
           this.Type = "LocalizedStringSet";
        }
    }
}
