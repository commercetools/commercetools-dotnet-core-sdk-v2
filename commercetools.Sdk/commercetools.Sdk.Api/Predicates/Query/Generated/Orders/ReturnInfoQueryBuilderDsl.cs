using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class ReturnInfoQueryBuilderDsl
    {
        public ReturnInfoQueryBuilderDsl()
        {
        }

        public static ReturnInfoQueryBuilderDsl Of()
        {
            return new ReturnInfoQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ReturnInfoQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemQueryBuilderDsl.Of())),
                ReturnInfoQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ReturnInfoQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<ReturnInfoQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<ReturnInfoQueryBuilderDsl>(p, ReturnInfoQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ReturnInfoQueryBuilderDsl, string> ReturnTrackingId()
        {
            return new ComparisonPredicateBuilder<ReturnInfoQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnTrackingId")),
            p => new CombinationQueryPredicate<ReturnInfoQueryBuilderDsl>(p, ReturnInfoQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnInfoQueryBuilderDsl, DateTime> ReturnDate()
        {
            return new ComparisonPredicateBuilder<ReturnInfoQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnDate")),
            p => new CombinationQueryPredicate<ReturnInfoQueryBuilderDsl>(p, ReturnInfoQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
