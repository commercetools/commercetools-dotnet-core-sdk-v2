using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderImportCustomLineItemStateActionQueryBuilderDsl
    {
        public StagedOrderImportCustomLineItemStateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderImportCustomLineItemStateActionQueryBuilderDsl Of()
        {
            return new StagedOrderImportCustomLineItemStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl>(p, StagedOrderImportCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl>(p, StagedOrderImportCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl>(p, StagedOrderImportCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl.Of())),
                StagedOrderImportCustomLineItemStateActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl> State()
        {
            return new CollectionPredicateBuilder<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
                    p => new CombinationQueryPredicate<StagedOrderImportCustomLineItemStateActionQueryBuilderDsl>(p, StagedOrderImportCustomLineItemStateActionQueryBuilderDsl.Of));
        }

    }
}
