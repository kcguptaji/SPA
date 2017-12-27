#region CodeCopyright
// // --------------------------------------------------------------------------------------------------------------------
//  <copyright  file="UserRole.cs" company="kcg, Inc.">
//   *     (C) 1997, 2001-2016, All rights reserved.  
//   *     This software constitutes the trade secrets and confidential  and proprietary information of kcg, Inc.  
//   *     It is intended solely for use by kcg, Inc.  This code may not be copied or redistributed to 
//   *     third parties without prior written authorization from kcg, Inc.
//  </copyright>
//  <summary>
//    The UserRole.cs.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
#endregion
namespace HomeCinema.Entities
{
    public class UserRole: IEntityBase
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}