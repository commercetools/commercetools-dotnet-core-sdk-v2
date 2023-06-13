
using System;
using commercetools.Sdk.Api.Predicates.Query.Common;
using commercetools.Sdk.Api.Predicates.Query.ProductTypes;

namespace commercetools.Sdk.Api.Predicates.Query.Products
{
    public partial class AttributeQueryBuilderDsl {
        public CombinationQueryPredicate<AttributeQueryBuilderDsl> PlainEnum(
                Func<AttributePlainEnumValueQueryBuilderDsl, CombinationQueryPredicate<AttributePlainEnumValueQueryBuilderDsl>> fn) {
            return new CombinationQueryPredicate<AttributeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                    .Parent(new ConstantQueryPredicate("value"))
                    .Inner(fn.Invoke(AttributePlainEnumValueQueryBuilderDsl.Of())),
                AttributeQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AttributeQueryBuilderDsl> LocalizedEnum(
                Func<AttributeLocalizedEnumValueQueryBuilderDsl, CombinationQueryPredicate<AttributeLocalizedEnumValueQueryBuilderDsl>> fn) {
            return new CombinationQueryPredicate<AttributeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                    .Parent(new ConstantQueryPredicate("value"))
                    .Inner(fn.Invoke(AttributeLocalizedEnumValueQueryBuilderDsl.Of())),
                AttributeQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AttributeQueryBuilderDsl> Money(
                Func<MoneyQueryBuilderDsl, CombinationQueryPredicate<MoneyQueryBuilderDsl>> fn) {
            return new CombinationQueryPredicate<AttributeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                    .Parent(new ConstantQueryPredicate("value"))
                    .Inner(fn.Invoke(MoneyQueryBuilderDsl.Of())),
                AttributeQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AttributeQueryBuilderDsl> Reference(
                Func<ReferenceQueryBuilderDsl, CombinationQueryPredicate<ReferenceQueryBuilderDsl>> fn) {
            return new CombinationQueryPredicate<AttributeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                    .Parent(new ConstantQueryPredicate("value"))
                    .Inner(fn.Invoke(ReferenceQueryBuilderDsl.Of())),
                AttributeQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AttributeQueryBuilderDsl, long> LongNumber() {
            return new ComparisonPredicateBuilder<AttributeQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
                p => new CombinationQueryPredicate<AttributeQueryBuilderDsl>(p, AttributeQueryBuilderDsl.Of),
                PredicateFormatter.Format);
        }

        public IComparisonPredicateBuilder<AttributeQueryBuilderDsl, decimal> DecimalNumber() {
            return new ComparisonPredicateBuilder<AttributeQueryBuilderDsl, decimal>(
                BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
                p => new CombinationQueryPredicate<AttributeQueryBuilderDsl>(p, AttributeQueryBuilderDsl.Of),
                PredicateFormatter.Format);
        }

        public IComparisonPredicateBuilder<AttributeQueryBuilderDsl, string> String() {
            return new ComparisonPredicateBuilder<AttributeQueryBuilderDsl, string>(
                BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
                p => new CombinationQueryPredicate<AttributeQueryBuilderDsl>(p, AttributeQueryBuilderDsl.Of),
                PredicateFormatter.Format);
        }
    }
}


