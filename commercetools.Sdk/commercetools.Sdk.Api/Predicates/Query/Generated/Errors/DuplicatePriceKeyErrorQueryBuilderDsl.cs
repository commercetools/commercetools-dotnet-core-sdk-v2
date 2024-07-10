using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class DuplicatePriceKeyErrorQueryBuilderDsl
    {
        public DuplicatePriceKeyErrorQueryBuilderDsl()
        {
        }

        public static DuplicatePriceKeyErrorQueryBuilderDsl Of()
        {
            return new DuplicatePriceKeyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DuplicatePriceKeyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DuplicatePriceKeyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DuplicatePriceKeyErrorQueryBuilderDsl>(p, DuplicatePriceKeyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicatePriceKeyErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<DuplicatePriceKeyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<DuplicatePriceKeyErrorQueryBuilderDsl>(p, DuplicatePriceKeyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DuplicatePriceKeyErrorQueryBuilderDsl> ConflictingPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DuplicatePriceKeyErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("conflictingPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                DuplicatePriceKeyErrorQueryBuilderDsl.Of);
        }


    }
}
