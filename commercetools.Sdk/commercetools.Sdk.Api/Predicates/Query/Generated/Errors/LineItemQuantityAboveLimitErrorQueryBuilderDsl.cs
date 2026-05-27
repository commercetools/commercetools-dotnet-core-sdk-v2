// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class LineItemQuantityAboveLimitErrorQueryBuilderDsl
    {
        public LineItemQuantityAboveLimitErrorQueryBuilderDsl()
        {
        }

        public static LineItemQuantityAboveLimitErrorQueryBuilderDsl Of()
        {
            return new LineItemQuantityAboveLimitErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LineItemQuantityAboveLimitErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<LineItemQuantityAboveLimitErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<LineItemQuantityAboveLimitErrorQueryBuilderDsl>(p, LineItemQuantityAboveLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQuantityAboveLimitErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<LineItemQuantityAboveLimitErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<LineItemQuantityAboveLimitErrorQueryBuilderDsl>(p, LineItemQuantityAboveLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQuantityAboveLimitErrorQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<LineItemQuantityAboveLimitErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<LineItemQuantityAboveLimitErrorQueryBuilderDsl>(p, LineItemQuantityAboveLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQuantityAboveLimitErrorQueryBuilderDsl, long> MaxCartQuantity()
        {
            return new ComparisonPredicateBuilder<LineItemQuantityAboveLimitErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxCartQuantity")),
            p => new CombinationQueryPredicate<LineItemQuantityAboveLimitErrorQueryBuilderDsl>(p, LineItemQuantityAboveLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQuantityAboveLimitErrorQueryBuilderDsl, string> LineItem()
        {
            return new ComparisonPredicateBuilder<LineItemQuantityAboveLimitErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItem")),
            p => new CombinationQueryPredicate<LineItemQuantityAboveLimitErrorQueryBuilderDsl>(p, LineItemQuantityAboveLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
