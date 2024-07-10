using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class ClientLoggingQueryBuilderDsl
    {
        public ClientLoggingQueryBuilderDsl()
        {
        }

        public static ClientLoggingQueryBuilderDsl Of()
        {
            return new ClientLoggingQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ClientLoggingQueryBuilderDsl, string> ClientId()
        {
            return new ComparisonPredicateBuilder<ClientLoggingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("clientId")),
            p => new CombinationQueryPredicate<ClientLoggingQueryBuilderDsl>(p, ClientLoggingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ClientLoggingQueryBuilderDsl, string> ExternalUserId()
        {
            return new ComparisonPredicateBuilder<ClientLoggingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalUserId")),
            p => new CombinationQueryPredicate<ClientLoggingQueryBuilderDsl>(p, ClientLoggingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ClientLoggingQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ClientLoggingQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                ClientLoggingQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ClientLoggingQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<ClientLoggingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<ClientLoggingQueryBuilderDsl>(p, ClientLoggingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ClientLoggingQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ClientLoggingQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                ClientLoggingQueryBuilderDsl.Of);
        }


        public CombinationQueryPredicate<ClientLoggingQueryBuilderDsl> AsCreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ClientLoggingQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of()),
                ClientLoggingQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ClientLoggingQueryBuilderDsl> AsLastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ClientLoggingQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of()),
                ClientLoggingQueryBuilderDsl.Of);
        }
    }
}
