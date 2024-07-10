using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeUpdate : ITypeUpdate
    {
        public long Version { get; set; }

        public IList<ITypeUpdateAction> Actions { get; set; }
        public IEnumerable<ITypeUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
