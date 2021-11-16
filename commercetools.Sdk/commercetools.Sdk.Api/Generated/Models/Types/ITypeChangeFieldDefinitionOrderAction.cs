using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeChangeFieldDefinitionOrderAction))]
    public partial interface ITypeChangeFieldDefinitionOrderAction : ITypeUpdateAction
    {
        List<string> FieldNames { get; set; }
    }
}
