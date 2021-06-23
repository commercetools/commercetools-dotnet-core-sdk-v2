using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class ClassificationShippingRateInput : IClassificationShippingRateInput
    {
        public IShippingRateInputType Type { get; set;}
        
        public string Key { get; set;}
        
        public ILocalizedString Label { get; set;}
        public ClassificationShippingRateInput()
        { 
           this.Type = IShippingRateInputType.FindEnum("Classification");
        }
    }
}
