using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodUpdateQueryBuilderDsl
    {
        public ShippingMethodUpdateQueryBuilderDsl()
        {
        }

        public static ShippingMethodUpdateQueryBuilderDsl Of()
        {
            return new ShippingMethodUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ShippingMethodUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ShippingMethodUpdateQueryBuilderDsl>(p, ShippingMethodUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodUpdateActionQueryBuilderDsl.Of())),
                ShippingMethodUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShippingMethodUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ShippingMethodUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ShippingMethodUpdateQueryBuilderDsl>(p, ShippingMethodUpdateQueryBuilderDsl.Of));
        }

    }
}
