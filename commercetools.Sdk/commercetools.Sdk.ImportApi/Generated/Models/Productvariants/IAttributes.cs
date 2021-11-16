using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.Attributes))]
    public interface IAttributes : IDictionary<string, IAttribute>
    {
    }
}
