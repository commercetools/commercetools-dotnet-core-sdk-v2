// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuoteSetSellerCommentActionQueryBuilderDsl
    {
        public StagedQuoteSetSellerCommentActionQueryBuilderDsl()
        {
        }

        public static StagedQuoteSetSellerCommentActionQueryBuilderDsl Of()
        {
            return new StagedQuoteSetSellerCommentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteSetSellerCommentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedQuoteSetSellerCommentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedQuoteSetSellerCommentActionQueryBuilderDsl>(p, StagedQuoteSetSellerCommentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteSetSellerCommentActionQueryBuilderDsl, string> SellerComment()
        {
            return new ComparisonPredicateBuilder<StagedQuoteSetSellerCommentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sellerComment")),
            p => new CombinationQueryPredicate<StagedQuoteSetSellerCommentActionQueryBuilderDsl>(p, StagedQuoteSetSellerCommentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
