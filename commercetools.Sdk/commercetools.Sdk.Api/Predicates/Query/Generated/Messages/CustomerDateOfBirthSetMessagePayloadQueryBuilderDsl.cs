using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl
    {
        public CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl>(p, CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl, Date> DateOfBirth()
        {
            return new ComparisonPredicateBuilder<CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dateOfBirth")),
            p => new CombinationQueryPredicate<CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl>(p, CustomerDateOfBirthSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
