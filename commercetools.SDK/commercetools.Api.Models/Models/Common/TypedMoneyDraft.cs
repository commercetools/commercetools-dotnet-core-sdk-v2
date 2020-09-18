using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [Discriminator(nameof(Type))]
    public abstract class TypedMoneyDraft : Money
    {
        public string Type { get; set;}
        
        public MoneyType TypeAsEnum => this.Type.GetEnum<MoneyType>();
    }
}
