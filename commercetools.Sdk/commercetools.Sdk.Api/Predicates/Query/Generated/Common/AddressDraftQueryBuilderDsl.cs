using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class AddressDraftQueryBuilderDsl
    {
        public AddressDraftQueryBuilderDsl()
        {
        }

        public static AddressDraftQueryBuilderDsl Of()
        {
            return new AddressDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Salutation()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("salutation")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> FirstName()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("firstName")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> LastName()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastName")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> StreetName()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("streetName")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> StreetNumber()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("streetNumber")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> AdditionalStreetInfo()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("additionalStreetInfo")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> PostalCode()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("postalCode")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> City()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("city")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Region()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("region")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Company()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("company")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Department()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("department")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Building()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("building")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Apartment()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("apartment")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> POBox()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("pOBox")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Phone()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("phone")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Mobile()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mobile")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> Fax()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fax")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> AdditionalAddressInfo()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("additionalAddressInfo")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<AddressDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(p, AddressDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AddressDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AddressDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                AddressDraftQueryBuilderDsl.Of);
        }


    }
}
