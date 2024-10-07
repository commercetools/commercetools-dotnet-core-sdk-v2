using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectUpdateActionQueryBuilderDsl
    {
        public ProjectUpdateActionQueryBuilderDsl()
        {
        }

        public static ProjectUpdateActionQueryBuilderDsl Of()
        {
            return new ProjectUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(p, ProjectUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeMyBusinessUnitStatusOnCreation(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeBusinessUnitStatusOnCreationActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeCartsConfiguration(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCartsConfigurationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCartsConfigurationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCartsConfigurationActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeCountries(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCountriesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCountriesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCountriesActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeCountryTaxRateFallbackEnabled(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCountryTaxRateFallbackEnabledActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeCurrencies(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCurrenciesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCurrenciesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCurrenciesActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeCustomerSearchStatus(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCustomerSearchStatusActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCustomerSearchStatusActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeCustomerSearchStatusActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeLanguages(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeLanguagesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeLanguagesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeLanguagesActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeMessagesConfiguration(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeMessagesConfigurationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeMessagesConfigurationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeMessagesConfigurationActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeNameActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeOrderSearchStatus(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeOrderSearchStatusActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeOrderSearchStatusActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeOrderSearchStatusActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeProductSearchIndexingEnabled(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeProductSearchIndexingEnabledActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsChangeShoppingListsConfiguration(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsSetMyBusinessUnitAssociateRoleOnCreation(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectSetBusinessUnitAssociateRoleOnCreationActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsSetExternalOAuth(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectSetExternalOAuthActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectSetExternalOAuthActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectSetExternalOAuthActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl> AsSetShippingRateInputType(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectSetShippingRateInputTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectSetShippingRateInputTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectSetShippingRateInputTypeActionQueryBuilderDsl.Of()),
                ProjectUpdateActionQueryBuilderDsl.Of);
        }
    }
}
