using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartLockQueryBuilderDsl
    {
        public CartLockQueryBuilderDsl()
        {
        }

        public static CartLockQueryBuilderDsl Of()
        {
            return new CartLockQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartLockQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CartLockQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CartLockQueryBuilderDsl>(p, CartLockQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartLockQueryBuilderDsl, string> ClientId()
        {
            return new ComparisonPredicateBuilder<CartLockQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("clientId")),
            p => new CombinationQueryPredicate<CartLockQueryBuilderDsl>(p, CartLockQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
