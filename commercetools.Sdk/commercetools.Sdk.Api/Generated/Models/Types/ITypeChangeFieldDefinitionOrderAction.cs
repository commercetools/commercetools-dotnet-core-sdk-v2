using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeFieldDefinitionOrderAction))]
    public partial interface ITypeChangeFieldDefinitionOrderAction : ITypeUpdateAction
    {
        List<string> FieldNames { get; set; }

    }
}
