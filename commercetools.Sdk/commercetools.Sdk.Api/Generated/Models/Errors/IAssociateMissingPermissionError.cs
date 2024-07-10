using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.AssociateMissingPermissionError))]
    public partial interface IAssociateMissingPermissionError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        ICustomerResourceIdentifier Associate { get; set; }

        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        ICustomerResourceIdentifier AssociateOnBehalf { get; set; }

        IList<IPermission> Permissions { get; set; }
        IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }


    }
}
