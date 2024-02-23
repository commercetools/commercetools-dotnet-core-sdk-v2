using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodPagedQueryResponseQueryBuilderDsl
    {
        public ShippingMethodPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ShippingMethodPagedQueryResponseQueryBuilderDsl Of()
        {
            return new ShippingMethodPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ShippingMethodPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ShippingMethodPagedQueryResponseQueryBuilderDsl>(p, ShippingMethodPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ShippingMethodPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ShippingMethodPagedQueryResponseQueryBuilderDsl>(p, ShippingMethodPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ShippingMethodPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ShippingMethodPagedQueryResponseQueryBuilderDsl>(p, ShippingMethodPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ShippingMethodPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ShippingMethodPagedQueryResponseQueryBuilderDsl>(p, ShippingMethodPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodQueryBuilderDsl.Of())),
                ShippingMethodPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShippingMethodPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ShippingMethodPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ShippingMethodPagedQueryResponseQueryBuilderDsl>(p, ShippingMethodPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
