using System;
using System.Collections.Generic;
using commercetools.Base.Models;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Sdk.Api.Predicates.Query.CartDiscounts;
using commercetools.Sdk.Api.Predicates.Query.Carts;
using commercetools.Sdk.Api.Predicates.Query.Channels;
using commercetools.Sdk.Api.Predicates.Query.Customers;
using commercetools.Sdk.Api.Predicates.Query.Messages;
using commercetools.Sdk.Api.Predicates.Query.Products;
using commercetools.Sdk.Api.Predicates.Query.States;
using commercetools.Sdk.Api.Predicates.Query.TaxCategories;
using commercetools.Sdk.Api.Predicates.Query.Types;
using Xunit;


namespace commercetools.Sdk.Api.Tests
{
    public class QueryTests
    {
        [Theory]
        [MemberData(nameof(Predicates))]
        public void PredicateRender(IQueryPredicate t, string expectedPredicate)
        {
            Assert.Equal(expectedPredicate, t.Render());
        }

        public static IEnumerable<object[]> Predicates()
        {
            return new List<object[]>()
            {
                new Object[] { CartQueryBuilderDsl.Of().Id().Is("abc"), "id = \"abc\"", },
                new Object[] { CartQueryBuilderDsl.Of().Id().Is("abc").Not(), "not(id = \"abc\")", },
                new Object[]
                {
                    CartQueryBuilderDsl.Of().Id().Is("abc").And(p => p.Id().Is("def")),
                    "id = \"abc\" and id = \"def\"",
                },
                new Object[]
                {
                    CartQueryBuilderDsl.Of().Id().Is("abc").Or(p => p.Id().Is("def")),
                    "id = \"abc\" or id = \"def\"",
                },
                new Object[]
                {
                    CartQueryBuilderDsl.Of().Id().Is("abc").And(p => p.Id().Is("def")).Or(p => p.Id().Is("ghi")),
                    "id = \"abc\" and id = \"def\" or id = \"ghi\"",
                },
                new Object[]
                {
                    CartQueryBuilderDsl.Of().Id().Is("abc").And(p => p.Id().Is("def").Or(p.Id().Is("ghi")).Group()),
                    "id = \"abc\" and (id = \"def\" or id = \"ghi\")",
                },
                new Object[]
                {
                    CartQueryBuilderDsl.Of()
                        .LineItems(p => p.Id().Is("abc"))
                        .And(p => p.Id().Is("def"))
                        .Or(p => p.Id().Is("ghi")),
                    "lineItems(id = \"abc\") and id = \"def\" or id = \"ghi\"",
                },
                new Object[]
                {
                    CartQueryBuilderDsl.Of()
                        .LineItems(p => p.TotalPrice(t => t.CurrencyCode().Is("EUR")))
                        .And(p => p.Id().Is("def"))
                        .Or(p => p.Id().Is("ghi")),
                    "lineItems(totalPrice(currencyCode = \"EUR\")) and id = \"def\" or id = \"ghi\"",
                },
                new Object[]
                {
                    CartQueryBuilderDsl.Of().CreatedAt().Is(DateTime.Parse("2018-10-12T14:00:00.000Z")),
                    "createdAt = \"2018-10-12T14:00:00Z\"",
                },
                new Object[] { CartQueryBuilderDsl.Of().Key().IsNot("foo"), "key != \"foo\"", },

                new Object[] { CartQueryBuilderDsl.Of().Version().IsLessThan(10L), "version < 10", },
                new Object[] { CartQueryBuilderDsl.Of().Version().IsGreaterThan(10L), "version > 10", },
                new Object[] { CartQueryBuilderDsl.Of().Version().IsLessThanOrEqual(10L), "version <= 10", },
                new Object[] { CartQueryBuilderDsl.Of().Version().IsGreaterThanOrEqual(10L), "version >= 10", },
                new Object[] { CartQueryBuilderDsl.Of().Version().IsNot(10L), "version <> 10", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().IsNot(10.0m), "amount <> 10.0", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().Is(10.0m), "amount = 10.0", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().IsLessThan(10.0m), "amount < 10.0", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().IsGreaterThan(10.0m), "amount > 10.0", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().IsLessThanOrEqual(10.0m), "amount <= 10.0", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().IsGreaterThanOrEqual(10.0m), "amount >= 10.0", },
                new Object[]
                {
                    CustomerQueryBuilderDsl.Of().DateOfBirth().Is(Date.Parse("2018-10-12")),
                    "dateOfBirth = \"2018-10-12\"",
                },
                new Object[]
                {
                    CustomerQueryBuilderDsl.Of().DateOfBirth().IsNot(Date.Parse("2018-10-12")),
                    "dateOfBirth != \"2018-10-12\"",
                },
                new Object[]
                {
                    CustomerQueryBuilderDsl.Of().DateOfBirth().IsLessThan(Date.Parse("2018-10-12")),
                    "dateOfBirth < \"2018-10-12\"",
                },
                new Object[]
                {
                    CustomerQueryBuilderDsl.Of().DateOfBirth().IsGreaterThan(Date.Parse("2018-10-12")),
                    "dateOfBirth > \"2018-10-12\"",
                },
                new Object[]
                {
                    CustomerQueryBuilderDsl.Of().DateOfBirth().IsLessThanOrEqual(Date.Parse("2018-10-12")),
                    "dateOfBirth <= \"2018-10-12\"",
                },
                new Object[]
                {
                    CustomerQueryBuilderDsl.Of().DateOfBirth().IsGreaterThanOrEqual(Date.Parse("2018-10-12")),
                    "dateOfBirth >= \"2018-10-12\"",
                },
                new Object[]
                {
                    CartQueryBuilderDsl.Of().Key().IsIn(new[] { "foo", "bar" }),
                    "key in (\"foo\", \"bar\")",
                },
                new Object[] { CartQueryBuilderDsl.Of().Version().IsIn(new[] { 1L, 2L }), "version in (1, 2)", },
                new Object[]
                {
                    TaxRateQueryBuilderDsl.Of().Amount().IsIn(new[] { 10.0m, 20.0m }),
                    "amount in (10.0, 20.0)",
                },
                new Object[]
                {
                    CustomerQueryBuilderDsl.Of()
                        .DateOfBirth()
                        .IsIn(new[] { Date.Parse("2018-10-12"), Date.Parse("2018-10-13") }),
                    "dateOfBirth in (\"2018-10-12\", \"2018-10-13\")",
                },
                new Object[]
                {
                    ChannelQueryBuilderDsl.Of().GeoLocation().WithinCircle(13.3777m, 52.51627m, 1000L),
                    "geoLocation within circle(13.3777, 52.51627, 1000)",
                },
                new Object[] { CartQueryBuilderDsl.Of().Key().IsDefined(), "key is defined", },
                new Object[] { CartQueryBuilderDsl.Of().Key().IsNotDefined(), "key is not defined", },
                new Object[] { CartQueryBuilderDsl.Of().LineItems().IsEmpty(), "lineItems is empty", },
                new Object[] { StateQueryBuilderDsl.Of().Roles().IsEmpty(), "roles is empty", },
                new Object[]
                {
                    TypeQueryBuilderDsl.Of()
                        .ResourceTypeIds()
                        .ContainsAny(new[] { IReferenceTypeId.Product.ToString() }),
                    "resourceTypeIds contains any(\"product\")",
                },
                new Object[]
                {
                    TypeQueryBuilderDsl.Of()
                        .ResourceTypeIds()
                        .ContainsAll(new[] { IReferenceTypeId.Product.ToString() }),
                    "resourceTypeIds contains all(\"product\")",
                },
                new Object[]
                {
                    ProductQueryBuilderDsl.Of()
                        .MasterData(m => m.Current(c => c.Slug(l => l.With("en").Is("super-product"))
                            .And(t => t.Name(l => l.With("en").Is("Super Product"))))),
                    "masterData(current(slug(en = \"super-product\") and name(en = \"Super Product\")))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(a => a.Name().Is("attribute-name")).Not()),
                    "variants(not(attributes(name = \"attribute-name\")))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(
                            a => a.Name().Is("attribute-name").And(av => av.Value().Is("attribute-value")))),
                    "variants(attributes(name = \"attribute-name\" and value = \"attribute-value\"))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(a => a.Name()
                            .Is("attribute-name")
                            .And(av => av.Value()
                                .IsIn(new[] { "attribute-value-1", "attribute-value-2" })))),
                    "variants(attributes(name = \"attribute-name\" and value in (\"attribute-value-1\", \"attribute-value-2\")))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(
                            a => a.Name().Is("attribute-name").And(av => av.PlainEnum(e => e.Key().Is("test"))))),
                    "variants(attributes(name = \"attribute-name\" and value(key = \"test\")))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(a => a.Name()
                            .Is("attribute-name")
                            .And(av => av
                                .LocalizedEnum(e => e.Label(l => l.With("en").Is("test")))))),
                    "variants(attributes(name = \"attribute-name\" and value(label(en = \"test\"))))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(a => a.Name()
                            .Is("attribute-name")
                            .And(av => av.Money(
                                m => m.CentAmount().Is(1000L).And(mc => mc.CurrencyCode().Is("EUR")))))),
                    "variants(attributes(name = \"attribute-name\" and value(centAmount = 1000 and currencyCode = \"EUR\")))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(a => a.Name()
                            .Is("attribute-name")
                            .And(av => av
                                .Reference(m => m.TypeId().Is(IReferenceTypeId.Cart.ToString()))))),
                    "variants(attributes(name = \"attribute-name\" and value(typeId = \"cart\")))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(
                            a => a.Name().Is("attribute-name").And(av => av.LongNumber().Is(999L)))),
                    "variants(attributes(name = \"attribute-name\" and value = 999))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(
                            a => a.Name().Is("attribute-name").And(av => av.DecimalNumber().Is(999.0m)))),
                    "variants(attributes(name = \"attribute-name\" and value = 999.0))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(
                            a => a.Name().Is("attribute-name").And(a.Value().Is("attribute-value")))),
                    "variants(attributes(name = \"attribute-name\" and value = \"attribute-value\"))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(a => a.Name()
                            .Is("attribute-name")
                            .And(a.Value().IsIn(new[] { "attribute-value-1", "attribute-value-2" })))),
                    "variants(attributes(name = \"attribute-name\" and value in (\"attribute-value-1\", \"attribute-value-2\")))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(
                            a => a.Name().Is("attribute-name").And(a.PlainEnum(e => e.Key().Is("test"))))),
                    "variants(attributes(name = \"attribute-name\" and value(key = \"test\")))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(a => a.Name()
                            .Is("attribute-name")
                            .And(a.LocalizedEnum(e => e.Label(l => l.With("en").Is("test")))))),
                    "variants(attributes(name = \"attribute-name\" and value(label(en = \"test\"))))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(a => a.Name()
                            .Is("attribute-name")
                            .And(a.Money(
                                m => m.CentAmount().Is(1000L).And(mc => mc.CurrencyCode().Is("EUR")))))),
                    "variants(attributes(name = \"attribute-name\" and value(centAmount = 1000 and currencyCode = \"EUR\")))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(a => a.Name()
                            .Is("attribute-name")
                            .And(a.Reference(m => m.TypeId().Is(IReferenceTypeId.Cart.ToString()))))),
                    "variants(attributes(name = \"attribute-name\" and value(typeId = \"cart\")))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(a => a.Name().Is("attribute-name").And(a.LongNumber().Is(999L)))),
                    "variants(attributes(name = \"attribute-name\" and value = 999))",
                },
                new Object[]
                {
                    ProductProjectionQueryBuilderDsl.Of()
                        .Variants(v => v.Attributes(
                            a => a.Name().Is("attribute-name").And(a.DecimalNumber().Is(999.0m)))),
                    "variants(attributes(name = \"attribute-name\" and value = 999.0))",
                },
                new Object[]
                {
                    CartDiscountQueryBuilderDsl.Of()
                        .Value(v => v.AsAbsolute(a => a.Money(c => c.CurrencyCode().Is("EUR")))),
                    "value(money(currencyCode = \"EUR\"))",
                },
                new Object[]
                {
                    CartDiscountQueryBuilderDsl.Of()
                        .Value(v => v.AsGiftLineItem(a => a.Product(p => p.Id().Is("abc")))),
                    "value(product(id = \"abc\"))",
                },
                new Object[]
                {
                    MessageQueryBuilderDsl.Of()
                        .AsCustomerCreated(message => message.Customer(c => c.Key().Is("foo"))),
                    "customer(key = \"foo\")",
                },
                new Object[]
                {
                    CartQueryBuilderDsl.Of()
                        .LineItems(l => l
                            .Price(p => p.Value(t => t.AsHighPrecision(h => h.PreciseAmount().Is(400L))))),
                    "lineItems(price(value(preciseAmount = 400)))",
                },
                new Object[]
                {
                    CartQueryBuilderDsl.Of().TotalPrice(l => l.CurrencyCode().Is("EUR")),
                    "totalPrice(currencyCode = \"EUR\")",
                },
                new Object[] { CartQueryBuilderDsl.Of().Id().Is("ab\"c"), "id = \"ab\\\"c\"", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().IsVar("foo"), "amount = :foo", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().IsLessThanVar("foo"), "amount < :foo", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().IsGreaterThanVar("foo"), "amount > :foo", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().IsLessThanOrEqualVar("foo"), "amount <= :foo", },
                new Object[] { TaxRateQueryBuilderDsl.Of().Amount().IsGreaterThanOrEqualVar("foo"), "amount >= :foo", },
                new Object[] { CartQueryBuilderDsl.Of().Key().IsInVar("foo"), "key in :foo" },
                new Object[]
                {
                    TypeQueryBuilderDsl.Of().ResourceTypeIds().ContainsAnyVar("foo"),
                    "resourceTypeIds contains any :foo",
                },
                new Object[]
                {
                    TypeQueryBuilderDsl.Of().ResourceTypeIds().ContainsAllVar("foo"),
                    "resourceTypeIds contains all :foo",
                },
            };
        }
    }
}