using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.Division))]
    public partial interface IDivision : IBusinessUnit
    {
        new IBusinessUnitKeyReference ParentUnit { get; set; }

        new IBusinessUnitStoreMode StoreMode { get; set; }

        new IBusinessUnitAssociateMode AssociateMode { get; set; }

        new IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }

    }
}
