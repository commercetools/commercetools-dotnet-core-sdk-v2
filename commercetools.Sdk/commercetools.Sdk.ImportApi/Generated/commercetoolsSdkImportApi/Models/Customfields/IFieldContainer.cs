using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.FieldContainer))]
    public partial interface IFieldContainer : IDictionary<string, ICustomField>
    {
    }
}
