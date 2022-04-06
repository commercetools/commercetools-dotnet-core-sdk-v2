using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    public partial class TextSetAttribute : ITextSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<string> Value { get; set; }
        public TextSetAttribute()
        {
            this.Type = "text-set";
        }
    }
}
