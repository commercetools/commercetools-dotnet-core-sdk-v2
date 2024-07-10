using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class AddressQueryBuilderDsl
    {
        public AddressQueryBuilderDsl()
        {
        }

        public static AddressQueryBuilderDsl Of()
        {
            return new AddressQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Salutation()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("salutation")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> FirstName()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("firstName")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> LastName()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastName")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> StreetName()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("streetName")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> StreetNumber()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("streetNumber")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> AdditionalStreetInfo()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("additionalStreetInfo")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> PostalCode()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("postalCode")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> City()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("city")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Region()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("region")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Company()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("company")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Department()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("department")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Building()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("building")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Apartment()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("apartment")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> POBox()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("pOBox")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Phone()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("phone")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Mobile()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mobile")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> Fax()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fax")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> AdditionalAddressInfo()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("additionalAddressInfo")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<AddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<AddressQueryBuilderDsl>(p, AddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AddressQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AddressQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                AddressQueryBuilderDsl.Of);
        }


    }
}
