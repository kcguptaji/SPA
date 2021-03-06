﻿#region CodeCopyright
// // --------------------------------------------------------------------------------------------------------------------
//  <copyright  file="Rental.cs" company="kcg, Inc.">
//   *     (C) 1997, 2001-2016, All rights reserved.  
//   *     This software constitutes the trade secrets and confidential  and proprietary information of kcg, Inc.  
//   *     It is intended solely for use by kcg, Inc.  This code may not be copied or redistributed to 
//   *     third parties without prior written authorization from kcg, Inc.
//  </copyright>
//  <summary>
//    The Rental.cs.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
#endregion

using System;

namespace HomeCinema.Entities
{
    public class Rental: IEntityBase
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }
        public DateTime RentalDate { get; set; }
        public Nullable<DateTime> ReturnedDate { get; set; }
        public string Status { get; set; }
    }
}