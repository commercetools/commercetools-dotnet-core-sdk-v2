// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerExternalIdSetMessagePayloadQueryBuilderDsl
    {
        public CustomerExternalIdSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerExternalIdSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerExternalIdSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerExternalIdSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerExternalIdSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerExternalIdSetMessagePayloadQueryBuilderDsl>(p, CustomerExternalIdSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerExternalIdSetMessagePayloadQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<CustomerExternalIdSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<CustomerExternalIdSetMessagePayloadQueryBuilderDsl>(p, CustomerExternalIdSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
