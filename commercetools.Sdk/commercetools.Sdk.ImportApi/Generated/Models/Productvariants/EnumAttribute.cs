namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class EnumAttribute : IEnumAttribute
    {
        public string Name { get; set;}
        
        public string Type { get; set;}
        
        public string Value { get; set;}
        public EnumAttribute()
        { 
           this.Type = "enum";
        }
    }
}
