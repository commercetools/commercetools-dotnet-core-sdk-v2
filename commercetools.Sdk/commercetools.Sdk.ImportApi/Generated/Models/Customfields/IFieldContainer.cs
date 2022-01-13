using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.FieldContainer))]
    public interface IFieldContainer : IDictionary<string, ICustomField>
    {
    }
}
