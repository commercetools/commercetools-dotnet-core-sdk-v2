namespace commercetools.ImportApi.Models.Customfields
{
    public partial class BooleanField : IBooleanField
    {
        public string Type { get; set; }

        public bool Value { get; set; }
        public BooleanField()
        {
            this.Type = "Boolean";
        }
    }
}
