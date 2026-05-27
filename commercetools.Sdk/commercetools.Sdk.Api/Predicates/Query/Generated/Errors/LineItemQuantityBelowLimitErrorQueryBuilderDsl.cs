// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class LineItemQuantityBelowLimitErrorQueryBuilderDsl
    {
        public LineItemQuantityBelowLimitErrorQueryBuilderDsl()
        {
        }

        public static LineItemQuantityBelowLimitErrorQueryBuilderDsl Of()
        {
            return new LineItemQuantityBelowLimitErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LineItemQuantityBelowLimitErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<LineItemQuantityBelowLimitErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<LineItemQuantityBelowLimitErrorQueryBuilderDsl>(p, LineItemQuantityBelowLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQuantityBelowLimitErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<LineItemQuantityBelowLimitErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<LineItemQuantityBelowLimitErrorQueryBuilderDsl>(p, LineItemQuantityBelowLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQuantityBelowLimitErrorQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<LineItemQuantityBelowLimitErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<LineItemQuantityBelowLimitErrorQueryBuilderDsl>(p, LineItemQuantityBelowLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQuantityBelowLimitErrorQueryBuilderDsl, long> MinCartQuantity()
        {
            return new ComparisonPredicateBuilder<LineItemQuantityBelowLimitErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("minCartQuantity")),
            p => new CombinationQueryPredicate<LineItemQuantityBelowLimitErrorQueryBuilderDsl>(p, LineItemQuantityBelowLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQuantityBelowLimitErrorQueryBuilderDsl, string> LineItem()
        {
            return new ComparisonPredicateBuilder<LineItemQuantityBelowLimitErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItem")),
            p => new CombinationQueryPredicate<LineItemQuantityBelowLimitErrorQueryBuilderDsl>(p, LineItemQuantityBelowLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
