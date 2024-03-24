using System;
using System.Collections.Generic;

namespace Self_Service_Checkout.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public double Price { get; set; }

    /// <summary>
    /// weight in grams
    /// </summary>
    public double Weight { get; set; }

    public int Barcode { get; set; }

    public virtual ICollection<TransactionItem> TransactionItems { get; set; } = new List<TransactionItem>();
}
