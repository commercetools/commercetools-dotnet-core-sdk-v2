// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class AzureServiceBusDestinationQueryBuilderDsl
    {
        public AzureServiceBusDestinationQueryBuilderDsl()
        {
        }

        public static AzureServiceBusDestinationQueryBuilderDsl Of()
        {
            return new AzureServiceBusDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AzureServiceBusDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AzureServiceBusDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AzureServiceBusDestinationQueryBuilderDsl>(p, AzureServiceBusDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AzureServiceBusDestinationQueryBuilderDsl, string> ConnectionString()
        {
            return new ComparisonPredicateBuilder<AzureServiceBusDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("connectionString")),
            p => new CombinationQueryPredicate<AzureServiceBusDestinationQueryBuilderDsl>(p, AzureServiceBusDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
