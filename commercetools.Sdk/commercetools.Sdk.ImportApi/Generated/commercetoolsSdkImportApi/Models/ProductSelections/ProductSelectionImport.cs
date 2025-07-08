using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.ProductSelections
{

    public partial class ProductSelectionImport : IProductSelectionImport
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public IProductSelectionMode Mode { get; set; }

        public ICustom Custom { get; set; }

        public IList<IProductSelectionAssignment> Assignments { get; set; }

        public IEnumerable<IProductSelectionAssignment> AssignmentsEnumerable { set => Assignments = value.ToList(); }
    }
}
