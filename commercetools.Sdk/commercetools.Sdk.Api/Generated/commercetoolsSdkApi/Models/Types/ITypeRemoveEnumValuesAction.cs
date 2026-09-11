using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeRemoveEnumValuesAction))]
    public partial interface ITypeRemoveEnumValuesAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        IList<string> Keys { get; set; }

        IEnumerable<string> KeysEnumerable { set => Keys = value.ToList(); }

    }
}
