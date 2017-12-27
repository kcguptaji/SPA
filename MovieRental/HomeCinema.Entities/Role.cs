#region CodeCopyright
// // --------------------------------------------------------------------------------------------------------------------
//  <copyright  file="Role.cs" company="kcg, Inc.">
//   *     (C) 1997, 2001-2016, All rights reserved.  
//   *     This software constitutes the trade secrets and confidential  and proprietary information of kcg, Inc.  
//   *     It is intended solely for use by kcg, Inc.  This code may not be copied or redistributed to 
//   *     third parties without prior written authorization from kcg, Inc.
//  </copyright>
//  <summary>
//    The Role.cs.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
#endregion
namespace HomeCinema.Entities
{
    public class Role: IEntityBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}