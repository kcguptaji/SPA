#region CodeCopyright

// // --------------------------------------------------------------------------------------------------------------------
//  <copyright  file="Disposable.cs" company="kcg, Inc.">
//   *     (C) 1997, 2001-2016, All rights reserved.  
//   *     This software constitutes the trade secrets and confidential  and proprietary information of kcg, Inc.  
//   *     It is intended solely for use by kcg, Inc.  This code may not be copied or redistributed to 
//   *     third parties without prior written authorization from kcg, Inc.
//  </copyright>
//  <summary>
//    The Disposable.cs.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

#endregion

#region

using System;

#endregion

namespace HomeCinema.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;


        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
                DisposeCore();
            isDisposed = true;
        }

        protected virtual void DisposeCore()
        {
        }
    }
}