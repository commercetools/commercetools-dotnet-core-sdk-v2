using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    public partial class MoneyAttribute : IMoneyAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public ITypedMoney Value { get; set; }
        public MoneyAttribute()
        {
            this.Type = "money";
        }
    }
}
