#region CodeCopyright
// // --------------------------------------------------------------------------------------------------------------------
//  <copyright  file="User.cs" company="Johnson Controls, Inc.">
//   *     (C) 1997, 2001-2016, All rights reserved.  
//   *     This software constitutes the trade secrets and confidential  and proprietary information of Johnson Controls, Inc.  
//   *     It is intended solely for use by Johnson Controls, Inc.  This code may not be copied or redistributed to 
//   *     third parties without prior written authorization from Johnson Controls, Inc.
//  </copyright>
//  <summary>
//    The User.cs.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;

namespace HomeCinema.Entities
{
    public class User: IEntityBase
    {
        public User()
        {
            UserRoles =new List<UserRole>();
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool IsLocked { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}