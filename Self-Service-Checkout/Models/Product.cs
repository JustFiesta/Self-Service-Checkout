using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Self_Service_Checkout.Models; 


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

    //[EnumDataType(typeof(Product_Category))]
    public Product_Category ProductCategory { get; set; }

    public virtual ICollection<TransactionItem> TransactionItems { get; set; } = new List<TransactionItem>();
}
