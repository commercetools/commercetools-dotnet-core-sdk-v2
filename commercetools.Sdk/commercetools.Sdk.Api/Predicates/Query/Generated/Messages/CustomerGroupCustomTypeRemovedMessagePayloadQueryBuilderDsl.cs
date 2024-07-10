// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl
    {
        public CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> OldTypeId()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldTypeId")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, CustomerGroupCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
