using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class ItemStateQueryBuilderDsl
    {
        public ItemStateQueryBuilderDsl()
        {
        }

        public static ItemStateQueryBuilderDsl Of()
        {
            return new ItemStateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ItemStateQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ItemStateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ItemStateQueryBuilderDsl>(p, ItemStateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ItemStateQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ItemStateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                ItemStateQueryBuilderDsl.Of);
        }


    }
}
