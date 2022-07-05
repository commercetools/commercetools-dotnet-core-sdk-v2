using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class MoneyField : IMoneyField
    {
        public string Type { get; set; }

        public ITypedMoney Value { get; set; }
        public MoneyField()
        {
            this.Type = "Money";
        }
    }
}
