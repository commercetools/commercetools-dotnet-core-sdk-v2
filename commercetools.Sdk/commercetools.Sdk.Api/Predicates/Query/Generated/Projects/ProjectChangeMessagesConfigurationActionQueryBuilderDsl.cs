using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeMessagesConfigurationActionQueryBuilderDsl
    {
        public ProjectChangeMessagesConfigurationActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeMessagesConfigurationActionQueryBuilderDsl Of()
        {
            return new ProjectChangeMessagesConfigurationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeMessagesConfigurationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeMessagesConfigurationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeMessagesConfigurationActionQueryBuilderDsl>(p, ProjectChangeMessagesConfigurationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProjectChangeMessagesConfigurationActionQueryBuilderDsl> MessagesConfiguration(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.MessagesConfigurationDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.MessagesConfigurationDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectChangeMessagesConfigurationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("messagesConfiguration"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.MessagesConfigurationDraftQueryBuilderDsl.Of())),
                ProjectChangeMessagesConfigurationActionQueryBuilderDsl.Of);
        }


    }
}
