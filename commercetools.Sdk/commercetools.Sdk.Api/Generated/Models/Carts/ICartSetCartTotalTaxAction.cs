using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCartTotalTaxAction))]
    public partial interface ICartSetCartTotalTaxAction : ICartUpdateAction
    {
        IMoney ExternalTotalGross { get; set; }

        IList<ITaxPortionDraft> ExternalTaxPortions { get; set; }
        IEnumerable<ITaxPortionDraft> ExternalTaxPortionsEnumerable { set => ExternalTaxPortions = value.ToList(); }


    }
}
