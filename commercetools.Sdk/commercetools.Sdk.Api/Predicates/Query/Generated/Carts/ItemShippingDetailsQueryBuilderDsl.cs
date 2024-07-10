using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ItemShippingDetailsQueryBuilderDsl
    {
        public ItemShippingDetailsQueryBuilderDsl()
        {
        }

        public static ItemShippingDetailsQueryBuilderDsl Of()
        {
            return new ItemShippingDetailsQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ItemShippingDetailsQueryBuilderDsl> Targets(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ItemShippingDetailsQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("targets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl.Of())),
                ItemShippingDetailsQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ItemShippingDetailsQueryBuilderDsl> Targets()
        {
            return new CollectionPredicateBuilder<ItemShippingDetailsQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("targets")),
                    p => new CombinationQueryPredicate<ItemShippingDetailsQueryBuilderDsl>(p, ItemShippingDetailsQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ItemShippingDetailsQueryBuilderDsl, bool> Valid()
        {
            return new ComparisonPredicateBuilder<ItemShippingDetailsQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("valid")),
            p => new CombinationQueryPredicate<ItemShippingDetailsQueryBuilderDsl>(p, ItemShippingDetailsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
