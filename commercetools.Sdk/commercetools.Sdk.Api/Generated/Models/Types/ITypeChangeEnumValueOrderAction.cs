using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeChangeEnumValueOrderAction))]
    public partial interface ITypeChangeEnumValueOrderAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        List<string> Keys { get; set; }
    }
}
