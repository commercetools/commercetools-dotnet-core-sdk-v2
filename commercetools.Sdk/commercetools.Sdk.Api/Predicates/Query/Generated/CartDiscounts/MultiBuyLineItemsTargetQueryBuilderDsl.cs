// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class MultiBuyLineItemsTargetQueryBuilderDsl
    {
        public MultiBuyLineItemsTargetQueryBuilderDsl()
        {
        }

        public static MultiBuyLineItemsTargetQueryBuilderDsl Of()
        {
            return new MultiBuyLineItemsTargetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<MultiBuyLineItemsTargetQueryBuilderDsl>(p, MultiBuyLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<MultiBuyLineItemsTargetQueryBuilderDsl>(p, MultiBuyLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, long> TriggerQuantity()
        {
            return new ComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("triggerQuantity")),
            p => new CombinationQueryPredicate<MultiBuyLineItemsTargetQueryBuilderDsl>(p, MultiBuyLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, long> DiscountedQuantity()
        {
            return new ComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountedQuantity")),
            p => new CombinationQueryPredicate<MultiBuyLineItemsTargetQueryBuilderDsl>(p, MultiBuyLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, long> MaxOccurrence()
        {
            return new ComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxOccurrence")),
            p => new CombinationQueryPredicate<MultiBuyLineItemsTargetQueryBuilderDsl>(p, MultiBuyLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, string> SelectionMode()
        {
            return new ComparisonPredicateBuilder<MultiBuyLineItemsTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("selectionMode")),
            p => new CombinationQueryPredicate<MultiBuyLineItemsTargetQueryBuilderDsl>(p, MultiBuyLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
