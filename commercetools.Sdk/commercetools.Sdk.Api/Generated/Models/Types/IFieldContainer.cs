using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.FieldContainer))]
    public interface IFieldContainer : IDictionary<string, Object>
    {
    }
}
