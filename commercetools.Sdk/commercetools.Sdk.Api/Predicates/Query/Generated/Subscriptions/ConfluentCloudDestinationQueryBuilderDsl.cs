// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class ConfluentCloudDestinationQueryBuilderDsl
    {
        public ConfluentCloudDestinationQueryBuilderDsl()
        {
        }

        public static ConfluentCloudDestinationQueryBuilderDsl Of()
        {
            return new ConfluentCloudDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ConfluentCloudDestinationQueryBuilderDsl>(p, ConfluentCloudDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string> BootstrapServer()
        {
            return new ComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("bootstrapServer")),
            p => new CombinationQueryPredicate<ConfluentCloudDestinationQueryBuilderDsl>(p, ConfluentCloudDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string> ApiKey()
        {
            return new ComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("apiKey")),
            p => new CombinationQueryPredicate<ConfluentCloudDestinationQueryBuilderDsl>(p, ConfluentCloudDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string> ApiSecret()
        {
            return new ComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("apiSecret")),
            p => new CombinationQueryPredicate<ConfluentCloudDestinationQueryBuilderDsl>(p, ConfluentCloudDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string> Acks()
        {
            return new ComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("acks")),
            p => new CombinationQueryPredicate<ConfluentCloudDestinationQueryBuilderDsl>(p, ConfluentCloudDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string> Topic()
        {
            return new ComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("topic")),
            p => new CombinationQueryPredicate<ConfluentCloudDestinationQueryBuilderDsl>(p, ConfluentCloudDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ConfluentCloudDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ConfluentCloudDestinationQueryBuilderDsl>(p, ConfluentCloudDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
