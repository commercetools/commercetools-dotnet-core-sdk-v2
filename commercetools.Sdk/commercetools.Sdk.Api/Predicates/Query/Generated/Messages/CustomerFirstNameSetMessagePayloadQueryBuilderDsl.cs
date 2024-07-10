using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerFirstNameSetMessagePayloadQueryBuilderDsl
    {
        public CustomerFirstNameSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerFirstNameSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerFirstNameSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerFirstNameSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerFirstNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerFirstNameSetMessagePayloadQueryBuilderDsl>(p, CustomerFirstNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerFirstNameSetMessagePayloadQueryBuilderDsl, string> FirstName()
        {
            return new ComparisonPredicateBuilder<CustomerFirstNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("firstName")),
            p => new CombinationQueryPredicate<CustomerFirstNameSetMessagePayloadQueryBuilderDsl>(p, CustomerFirstNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
