using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeFieldDefinitionOrderAction))]
    public partial interface ITypeChangeFieldDefinitionOrderAction : ITypeUpdateAction
    {
        IList<string> FieldNames { get; set; }
        IEnumerable<string> FieldNamesEnumerable { set => FieldNames = value.ToList(); }


    }
}
