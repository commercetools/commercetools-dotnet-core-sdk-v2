using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class BaseAddressQueryBuilderDsl
    {
        public BaseAddressQueryBuilderDsl()
        {
        }

        public static BaseAddressQueryBuilderDsl Of()
        {
            return new BaseAddressQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Salutation()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("salutation")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> FirstName()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("firstName")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> LastName()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastName")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> StreetName()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("streetName")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> StreetNumber()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("streetNumber")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> AdditionalStreetInfo()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("additionalStreetInfo")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> PostalCode()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("postalCode")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> City()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("city")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Region()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("region")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Company()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("company")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Department()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("department")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Building()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("building")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Apartment()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("apartment")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> POBox()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("pOBox")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Phone()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("phone")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Mobile()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mobile")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> Fax()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fax")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> AdditionalAddressInfo()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("additionalAddressInfo")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<BaseAddressQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(p, BaseAddressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<BaseAddressQueryBuilderDsl> AsAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of()),
                BaseAddressQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseAddressQueryBuilderDsl> AsAddressDraft(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseAddressQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressDraftQueryBuilderDsl.Of()),
                BaseAddressQueryBuilderDsl.Of);
        }
    }
}
