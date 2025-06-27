using System;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerQueryBuilderDsl
    {
        public CustomerQueryBuilderDsl()
        {
        }

        public static CustomerQueryBuilderDsl Of()
        {
            return new CustomerQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> CustomerNumber()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerNumber")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomerQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomerQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> Password()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("password")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> FirstName()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("firstName")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> LastName()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastName")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> MiddleName()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("middleName")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, Date> DateOfBirth()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dateOfBirth")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> CompanyName()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("companyName")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> VatId()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("vatId")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CustomerQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<CustomerQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> DefaultShippingAddressId()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddressId")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CustomerQueryBuilderDsl, string> ShippingAddressIds()
        {
            return new ComparableCollectionPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingAddressIds")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> DefaultBillingAddressId()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddressId")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CustomerQueryBuilderDsl, string> BillingAddressIds()
        {
            return new ComparableCollectionPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("billingAddressIds")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, bool> IsEmailVerified()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isEmailVerified")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                CustomerQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerQueryBuilderDsl> CustomerGroupAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl.Of())),
                CustomerQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerQueryBuilderDsl> CustomerGroupAssignments()
        {
            return new CollectionPredicateBuilder<CustomerQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerGroupAssignments")),
                    p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CustomerQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CustomerQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> Salutation()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("salutation")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                CustomerQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CustomerQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CustomerQueryBuilderDsl, string> AuthenticationMode()
        {
            return new ComparisonPredicateBuilder<CustomerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("authenticationMode")),
            p => new CombinationQueryPredicate<CustomerQueryBuilderDsl>(p, CustomerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
