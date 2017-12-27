#region CodeCopyright

// // --------------------------------------------------------------------------------------------------------------------
//  <copyright  file="CustomerConfiguration.cs" company="kcg, Inc.">
//   *     (C) 1997, 2001-2016, All rights reserved.  
//   *     This software constitutes the trade secrets and confidential  and proprietary information of kcg, Inc.  
//   *     It is intended solely for use by kcg, Inc.  This code may not be copied or redistributed to 
//   *     third parties without prior written authorization from kcg, Inc.
//  </copyright>
//  <summary>
//    The CustomerConfiguration.cs.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

#endregion

#region

using HomeCinema.Entities;

#endregion

namespace HomeCinema.Data.Configurations
{
    public class CustomerConfiguration : EntityBaseConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            Property(c => c.FirstName).IsRequired().HasMaxLength(100);
            Property(c => c.LastName).IsRequired().HasMaxLength(100);
            Property(c => c.IdentityCard).IsRequired().HasMaxLength(50);
            Property(c => c.UniqueKey).IsRequired();
            Property(c => c.Mobile).IsRequired().HasMaxLength(10);
            Property(c => c.Email).IsRequired().HasMaxLength(200);
            Property(c => c.DateOfBirth).IsRequired();
        }
    }
}