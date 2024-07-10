using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl
    {
        public CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl>(p, CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl> CustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl, string> OldTypeId()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldTypeId")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl>(p, CustomerGroupCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
