namespace commercetools.Sdk.ImportApi.Models.Types
{

    public partial class CustomFieldMoneyType : ICustomFieldMoneyType
    {
        public string Name { get; set; }
        public CustomFieldMoneyType()
        {
            this.Name = "Money";
        }
    }
}
