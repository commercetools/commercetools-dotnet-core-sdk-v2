using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Common
{
    public interface ITypedMoneyDraft : IMoney
    {
        string Type { get; set;}
        
        MoneyType TypeAsEnum { get; }
    }
}
