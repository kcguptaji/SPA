﻿#region CodeCopyright
// // --------------------------------------------------------------------------------------------------------------------
//  <copyright  file="Customer.cs" company="kcg, Inc.">
//   *     (C) 1997, 2001-2016, All rights reserved.  
//   *     This software constitutes the trade secrets and confidential  and proprietary information of kcg, Inc.  
//   *     It is intended solely for use by kcg, Inc.  This code may not be copied or redistributed to 
//   *     third parties without prior written authorization from kcg, Inc.
//  </copyright>
//  <summary>
//    The Customer.cs.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
#endregion

using System;

namespace HomeCinema.Entities
{
    public class Customer: IEntityBase
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IdentityCard { get; set; }
        public Guid UniqueKey { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}