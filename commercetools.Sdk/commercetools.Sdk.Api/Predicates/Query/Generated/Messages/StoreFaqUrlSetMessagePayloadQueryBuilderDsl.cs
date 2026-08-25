// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreFaqUrlSetMessagePayloadQueryBuilderDsl
    {
        public StoreFaqUrlSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreFaqUrlSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreFaqUrlSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreFaqUrlSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreFaqUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreFaqUrlSetMessagePayloadQueryBuilderDsl>(p, StoreFaqUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreFaqUrlSetMessagePayloadQueryBuilderDsl, string> FaqUrl()
        {
            return new ComparisonPredicateBuilder<StoreFaqUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("faqUrl")),
            p => new CombinationQueryPredicate<StoreFaqUrlSetMessagePayloadQueryBuilderDsl>(p, StoreFaqUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
