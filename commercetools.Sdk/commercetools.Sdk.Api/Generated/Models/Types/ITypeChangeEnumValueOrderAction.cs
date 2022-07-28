using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueOrderAction))]
    public partial interface ITypeChangeEnumValueOrderAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        List<string> Keys { get; set; }

    }
}
