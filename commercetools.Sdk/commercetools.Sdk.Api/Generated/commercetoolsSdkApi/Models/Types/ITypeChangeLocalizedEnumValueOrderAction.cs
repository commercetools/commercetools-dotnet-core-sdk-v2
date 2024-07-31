using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueOrderAction))]
    public partial interface ITypeChangeLocalizedEnumValueOrderAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        IList<string> Keys { get; set; }

        IEnumerable<string> KeysEnumerable { set => Keys = value.ToList(); }

    }
}
