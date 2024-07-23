using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class AssociateMissingPermissionError : IAssociateMissingPermissionError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public ICustomerResourceIdentifier Associate { get; set; }

        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        public ICustomerResourceIdentifier AssociateOnBehalf { get; set; }

        public IList<IPermission> Permissions { get; set; }
        public IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }

        public AssociateMissingPermissionError()
        {
            this.Code = "AssociateMissingPermission";
        }
    }
}
