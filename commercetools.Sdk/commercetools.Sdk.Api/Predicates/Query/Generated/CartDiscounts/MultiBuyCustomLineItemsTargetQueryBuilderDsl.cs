using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class MultiBuyCustomLineItemsTargetQueryBuilderDsl
    {
        public MultiBuyCustomLineItemsTargetQueryBuilderDsl()
        {
        }

        public static MultiBuyCustomLineItemsTargetQueryBuilderDsl Of()
        {
            return new MultiBuyCustomLineItemsTargetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<MultiBuyCustomLineItemsTargetQueryBuilderDsl>(p, MultiBuyCustomLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<MultiBuyCustomLineItemsTargetQueryBuilderDsl>(p, MultiBuyCustomLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, long> TriggerQuantity()
        {
            return new ComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("triggerQuantity")),
            p => new CombinationQueryPredicate<MultiBuyCustomLineItemsTargetQueryBuilderDsl>(p, MultiBuyCustomLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, long> DiscountedQuantity()
        {
            return new ComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountedQuantity")),
            p => new CombinationQueryPredicate<MultiBuyCustomLineItemsTargetQueryBuilderDsl>(p, MultiBuyCustomLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, long> MaxOccurrence()
        {
            return new ComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxOccurrence")),
            p => new CombinationQueryPredicate<MultiBuyCustomLineItemsTargetQueryBuilderDsl>(p, MultiBuyCustomLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, string> SelectionMode()
        {
            return new ComparisonPredicateBuilder<MultiBuyCustomLineItemsTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("selectionMode")),
            p => new CombinationQueryPredicate<MultiBuyCustomLineItemsTargetQueryBuilderDsl>(p, MultiBuyCustomLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
