using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class LocalizedStringField : ILocalizedStringField
    {
        public string Type { get; set;}
        
        public ILocalizedString Value { get; set;}
        public LocalizedStringField()
        { 
           this.Type = "LocalizedString";
        }
    }
}
