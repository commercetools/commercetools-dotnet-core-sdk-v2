using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueOrderAction))]
    public partial interface ITypeChangeEnumValueOrderAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        IList<string> Keys { get; set; }
        IEnumerable<string> KeysEnumerable { set => Keys = value.ToList(); }


    }
}
