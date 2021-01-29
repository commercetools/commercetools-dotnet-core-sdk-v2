using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class MoneyField : IMoneyField
    {
        public string Type { get; set;}
        
        public ITypedMoney Value { get; set;}
        public MoneyField()
        { 
           this.Type = "Money";
        }
    }
}
