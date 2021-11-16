namespace commercetools.ImportApi.Models.Producttypes
{
    public partial class AttributeBooleanType : IAttributeBooleanType
    {
        public string Name { get; set; }
        public AttributeBooleanType()
        {
            this.Name = "boolean";
        }
    }
}
