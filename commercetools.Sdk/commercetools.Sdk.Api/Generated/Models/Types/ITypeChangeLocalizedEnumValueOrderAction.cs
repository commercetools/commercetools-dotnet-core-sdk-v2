using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueOrderAction))]
    public partial interface ITypeChangeLocalizedEnumValueOrderAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        List<string> Keys { get; set; }

    }
}
