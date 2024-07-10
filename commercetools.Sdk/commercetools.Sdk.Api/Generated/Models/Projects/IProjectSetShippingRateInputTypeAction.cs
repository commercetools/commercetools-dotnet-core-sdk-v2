using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetShippingRateInputTypeAction))]
    public partial interface IProjectSetShippingRateInputTypeAction : IProjectUpdateAction
    {
        IShippingRateInputType ShippingRateInputType { get; set; }

    }
}
