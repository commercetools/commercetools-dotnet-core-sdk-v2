using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class MoneySetAttribute : IMoneySetAttribute
    {
        public string Name { get; set;}
        
        public string Type { get; set;}
        
        public List<ITypedMoney> Value { get; set;}
        public MoneySetAttribute()
        { 
           this.Type = "money-set";
        }
    }
}
