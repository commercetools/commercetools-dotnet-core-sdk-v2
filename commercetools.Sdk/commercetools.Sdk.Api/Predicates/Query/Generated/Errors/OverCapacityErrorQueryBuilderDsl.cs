using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class OverCapacityErrorQueryBuilderDsl
    {
        public OverCapacityErrorQueryBuilderDsl()
        {
        }

        public static OverCapacityErrorQueryBuilderDsl Of()
        {
            return new OverCapacityErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OverCapacityErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<OverCapacityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<OverCapacityErrorQueryBuilderDsl>(p, OverCapacityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OverCapacityErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<OverCapacityErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<OverCapacityErrorQueryBuilderDsl>(p, OverCapacityErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
