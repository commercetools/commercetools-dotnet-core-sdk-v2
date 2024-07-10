using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectQueryBuilderDsl
    {
        public ProjectQueryBuilderDsl()
        {
        }

        public static ProjectQueryBuilderDsl Of()
        {
            return new ProjectQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProjectQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProjectQueryBuilderDsl>(p, ProjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProjectQueryBuilderDsl>(p, ProjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProjectQueryBuilderDsl>(p, ProjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProjectQueryBuilderDsl, string> Countries()
        {
            return new ComparableCollectionPredicateBuilder<ProjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("countries")),
            p => new CombinationQueryPredicate<ProjectQueryBuilderDsl>(p, ProjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProjectQueryBuilderDsl, string> Currencies()
        {
            return new ComparableCollectionPredicateBuilder<ProjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currencies")),
            p => new CombinationQueryPredicate<ProjectQueryBuilderDsl>(p, ProjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProjectQueryBuilderDsl, string> Languages()
        {
            return new ComparableCollectionPredicateBuilder<ProjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("languages")),
            p => new CombinationQueryPredicate<ProjectQueryBuilderDsl>(p, ProjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProjectQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProjectQueryBuilderDsl>(p, ProjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectQueryBuilderDsl, string> TrialUntil()
        {
            return new ComparisonPredicateBuilder<ProjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("trialUntil")),
            p => new CombinationQueryPredicate<ProjectQueryBuilderDsl>(p, ProjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProjectQueryBuilderDsl> Messages(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.MessagesConfigurationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.MessagesConfigurationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("messages"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.MessagesConfigurationQueryBuilderDsl.Of())),
                ProjectQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProjectQueryBuilderDsl> Carts(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.CartsConfigurationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.CartsConfigurationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("carts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.CartsConfigurationQueryBuilderDsl.Of())),
                ProjectQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProjectQueryBuilderDsl> ShoppingLists(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ShoppingListsConfigurationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ShoppingListsConfigurationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shoppingLists"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ShoppingListsConfigurationQueryBuilderDsl.Of())),
                ProjectQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProjectQueryBuilderDsl> ShippingRateInputType(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ShippingRateInputTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ShippingRateInputTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInputType"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ShippingRateInputTypeQueryBuilderDsl.Of())),
                ProjectQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProjectQueryBuilderDsl> ExternalOAuth(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ExternalOAuthQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ExternalOAuthQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalOAuth"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ExternalOAuthQueryBuilderDsl.Of())),
                ProjectQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProjectQueryBuilderDsl> SearchIndexing(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("searchIndexing"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationQueryBuilderDsl.Of())),
                ProjectQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProjectQueryBuilderDsl> BusinessUnits(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.BusinessUnitConfigurationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.BusinessUnitConfigurationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnits"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.BusinessUnitConfigurationQueryBuilderDsl.Of())),
                ProjectQueryBuilderDsl.Of);
        }


    }
}
