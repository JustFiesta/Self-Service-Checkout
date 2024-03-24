using System;
using System.Collections.Generic;

namespace Self_Service_Checkout.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public double TotalAmount { get; set; }

    public int? EmployeesFk { get; set; }

    public int? CustomerFk { get; set; }

    public virtual Customer? CustomerFkNavigation { get; set; }

    public virtual Employee? EmployeesFkNavigation { get; set; }

    public virtual ICollection<TransactionItem> TransactionItems { get; set; } = new List<TransactionItem>();
}
