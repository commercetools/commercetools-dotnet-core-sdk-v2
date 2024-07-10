// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl
    {
        public CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> PreviousTypeId()
        {
            return new ComparisonPredicateBuilder<CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousTypeId")),
            p => new CombinationQueryPredicate<CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, CustomerCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
