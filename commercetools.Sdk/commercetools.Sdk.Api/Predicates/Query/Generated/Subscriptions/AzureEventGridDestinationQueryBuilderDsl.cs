// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class AzureEventGridDestinationQueryBuilderDsl
    {
        public AzureEventGridDestinationQueryBuilderDsl()
        {
        }

        public static AzureEventGridDestinationQueryBuilderDsl Of()
        {
            return new AzureEventGridDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AzureEventGridDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AzureEventGridDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AzureEventGridDestinationQueryBuilderDsl>(p, AzureEventGridDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AzureEventGridDestinationQueryBuilderDsl, string> Uri()
        {
            return new ComparisonPredicateBuilder<AzureEventGridDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("uri")),
            p => new CombinationQueryPredicate<AzureEventGridDestinationQueryBuilderDsl>(p, AzureEventGridDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AzureEventGridDestinationQueryBuilderDsl, string> AccessKey()
        {
            return new ComparisonPredicateBuilder<AzureEventGridDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("accessKey")),
            p => new CombinationQueryPredicate<AzureEventGridDestinationQueryBuilderDsl>(p, AzureEventGridDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
