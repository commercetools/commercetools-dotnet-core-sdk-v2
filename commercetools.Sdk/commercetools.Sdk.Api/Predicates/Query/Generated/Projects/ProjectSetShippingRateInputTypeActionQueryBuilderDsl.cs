using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectSetShippingRateInputTypeActionQueryBuilderDsl
    {
        public ProjectSetShippingRateInputTypeActionQueryBuilderDsl()
        {
        }

        public static ProjectSetShippingRateInputTypeActionQueryBuilderDsl Of()
        {
            return new ProjectSetShippingRateInputTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectSetShippingRateInputTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectSetShippingRateInputTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectSetShippingRateInputTypeActionQueryBuilderDsl>(p, ProjectSetShippingRateInputTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProjectSetShippingRateInputTypeActionQueryBuilderDsl> ShippingRateInputType(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ShippingRateInputTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ShippingRateInputTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectSetShippingRateInputTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInputType"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ShippingRateInputTypeQueryBuilderDsl.Of())),
                ProjectSetShippingRateInputTypeActionQueryBuilderDsl.Of);
        }


    }
}
