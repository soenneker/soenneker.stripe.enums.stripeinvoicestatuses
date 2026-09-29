using Soenneker.Gen.EnumValues;

namespace Soenneker.Stripe.Enums.StripeInvoiceStatuses;

/// <summary>
/// Stripe invoice statuses.
/// </summary>
[EnumValue<string>]
public sealed partial class StripeInvoiceStatus
{
    public static readonly StripeInvoiceStatus Draft = new("draft");
    public static readonly StripeInvoiceStatus Open = new("open");
    public static readonly StripeInvoiceStatus Paid = new("paid");
    public static readonly StripeInvoiceStatus Uncollectible = new("uncollectible");
    public static readonly StripeInvoiceStatus Void = new("void");
}
