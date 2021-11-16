using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Customfields
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
