namespace commercetools.ImportApi.Models.Producttypes
{
    public partial class AttributeDateType : IAttributeDateType
    {
        public string Name { get; set;}
        public AttributeDateType()
        { 
           this.Name = "date";
        }
    }
}
