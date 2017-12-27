#region CodeCopyright

// // --------------------------------------------------------------------------------------------------------------------
//  <copyright  file="IUnitOfWork.cs" company="kcg, Inc.">
//   *     (C) 1997, 2001-2016, All rights reserved.  
//   *     This software constitutes the trade secrets and confidential  and proprietary information of kcg, Inc.  
//   *     It is intended solely for use by kcg, Inc.  This code may not be copied or redistributed to 
//   *     third parties without prior written authorization from kcg, Inc.
//  </copyright>
//  <summary>
//    The IUnitOfWork.cs.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

#endregion

namespace HomeCinema.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}