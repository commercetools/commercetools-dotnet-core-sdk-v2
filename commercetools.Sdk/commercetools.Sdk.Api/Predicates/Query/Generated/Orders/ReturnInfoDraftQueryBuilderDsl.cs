using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class ReturnInfoDraftQueryBuilderDsl
    {
        public ReturnInfoDraftQueryBuilderDsl()
        {
        }

        public static ReturnInfoDraftQueryBuilderDsl Of()
        {
            return new ReturnInfoDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ReturnInfoDraftQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnInfoDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemDraftQueryBuilderDsl.Of())),
                ReturnInfoDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ReturnInfoDraftQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<ReturnInfoDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<ReturnInfoDraftQueryBuilderDsl>(p, ReturnInfoDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ReturnInfoDraftQueryBuilderDsl, string> ReturnTrackingId()
        {
            return new ComparisonPredicateBuilder<ReturnInfoDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnTrackingId")),
            p => new CombinationQueryPredicate<ReturnInfoDraftQueryBuilderDsl>(p, ReturnInfoDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnInfoDraftQueryBuilderDsl, DateTime> ReturnDate()
        {
            return new ComparisonPredicateBuilder<ReturnInfoDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnDate")),
            p => new CombinationQueryPredicate<ReturnInfoDraftQueryBuilderDsl>(p, ReturnInfoDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
