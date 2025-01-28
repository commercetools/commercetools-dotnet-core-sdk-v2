using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.FieldContainer))]
    public partial interface IFieldContainer : IDictionary<string, Object>
    {
    }
}
