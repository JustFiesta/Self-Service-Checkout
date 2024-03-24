using System;
using System.Collections.Generic;

namespace Self_Service_Checkout.Models;

public partial class TransactionItem
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    public double Amount { get; set; }

    public int ProductFk { get; set; }

    public int TransactionFk { get; set; }

    public virtual Product ProductFkNavigation { get; set; } = null!;

    public virtual Transaction TransactionFkNavigation { get; set; } = null!;
}
