using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeSetMaxApplicationsActionQueryBuilderDsl
    {
        public DiscountCodeSetMaxApplicationsActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeSetMaxApplicationsActionQueryBuilderDsl Of()
        {
            return new DiscountCodeSetMaxApplicationsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeSetMaxApplicationsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetMaxApplicationsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeSetMaxApplicationsActionQueryBuilderDsl>(p, DiscountCodeSetMaxApplicationsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeSetMaxApplicationsActionQueryBuilderDsl, long> MaxApplications()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetMaxApplicationsActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxApplications")),
            p => new CombinationQueryPredicate<DiscountCodeSetMaxApplicationsActionQueryBuilderDsl>(p, DiscountCodeSetMaxApplicationsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
