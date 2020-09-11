using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class TypeChangeNameAction : TypeUpdateAction
    {
        public LocalizedString Name { get; set;}
    }
}
