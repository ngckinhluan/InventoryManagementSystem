﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace IMS.BusinessObjects.Models;

public partial class StockLevel
{
    public int StockLevelId { get; set; }

    public int? ProductId { get; set; }

    public int? WarehouseId { get; set; }

    public int Quantity { get; set; }

    public DateTime? LastUpdated { get; set; }

    public virtual Product Product { get; set; }

    public virtual Warehouse Warehouse { get; set; }
}