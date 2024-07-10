using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateReference : IStateReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IState Obj { get; set; }
        public StateReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("state");
        }
    }
}
