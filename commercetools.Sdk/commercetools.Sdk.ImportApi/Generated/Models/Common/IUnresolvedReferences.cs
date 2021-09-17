using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.UnresolvedReferences))]
    public partial interface IUnresolvedReferences
    {
        string Key { get; set; }

        IReferenceType TypeId { get; set; }
    }
}
