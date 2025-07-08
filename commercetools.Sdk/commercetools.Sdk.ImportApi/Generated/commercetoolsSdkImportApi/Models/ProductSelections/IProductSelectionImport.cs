using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.ProductSelections.ProductSelectionImport))]
    public partial interface IProductSelectionImport : IImportResource
    {
        new string Key { get; set; }

        ILocalizedString Name { get; set; }

        IProductSelectionMode Mode { get; set; }

        ICustom Custom { get; set; }

        IList<IProductSelectionAssignment> Assignments { get; set; }

        IEnumerable<IProductSelectionAssignment> AssignmentsEnumerable { set => Assignments = value.ToList(); }

    }
}
