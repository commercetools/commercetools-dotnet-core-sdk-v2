using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class DateField : IDateField
    {
        public string Type { get; set; }

        public Date Value { get; set; }
        public DateField()
        {
            this.Type = "Date";
        }
    }
}
