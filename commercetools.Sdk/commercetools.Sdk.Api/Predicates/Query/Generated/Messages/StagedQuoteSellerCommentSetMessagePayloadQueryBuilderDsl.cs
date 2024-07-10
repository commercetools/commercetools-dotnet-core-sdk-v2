using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl
    {
        public StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl>(p, StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl, string> SellerComment()
        {
            return new ComparisonPredicateBuilder<StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sellerComment")),
            p => new CombinationQueryPredicate<StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl>(p, StagedQuoteSellerCommentSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
