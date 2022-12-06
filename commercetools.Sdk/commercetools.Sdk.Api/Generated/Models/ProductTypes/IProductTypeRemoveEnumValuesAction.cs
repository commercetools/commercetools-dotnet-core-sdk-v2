using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveEnumValuesAction))]
    public partial interface IProductTypeRemoveEnumValuesAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IList<string> Keys { get; set; }
        IEnumerable<string> KeysEnumerable { set => Keys = value.ToList(); }


    }
}
