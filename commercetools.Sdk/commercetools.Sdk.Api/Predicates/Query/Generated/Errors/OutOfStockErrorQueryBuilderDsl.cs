using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class OutOfStockErrorQueryBuilderDsl
    {
        public OutOfStockErrorQueryBuilderDsl()
        {
        }

        public static OutOfStockErrorQueryBuilderDsl Of()
        {
            return new OutOfStockErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OutOfStockErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<OutOfStockErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<OutOfStockErrorQueryBuilderDsl>(p, OutOfStockErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OutOfStockErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<OutOfStockErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<OutOfStockErrorQueryBuilderDsl>(p, OutOfStockErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<OutOfStockErrorQueryBuilderDsl, string> LineItems()
        {
            return new ComparableCollectionPredicateBuilder<OutOfStockErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
            p => new CombinationQueryPredicate<OutOfStockErrorQueryBuilderDsl>(p, OutOfStockErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<OutOfStockErrorQueryBuilderDsl, string> Skus()
        {
            return new ComparableCollectionPredicateBuilder<OutOfStockErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("skus")),
            p => new CombinationQueryPredicate<OutOfStockErrorQueryBuilderDsl>(p, OutOfStockErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
