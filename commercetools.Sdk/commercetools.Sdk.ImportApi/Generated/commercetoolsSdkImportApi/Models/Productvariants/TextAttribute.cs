namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class TextAttribute : ITextAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }
        public TextAttribute()
        {
            this.Type = "text";
        }
    }
}
