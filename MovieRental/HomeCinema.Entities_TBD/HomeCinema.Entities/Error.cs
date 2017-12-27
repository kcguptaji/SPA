#region CodeCopyright
// // --------------------------------------------------------------------------------------------------------------------
//  <copyright  file="Error.cs" company="Johnson Controls, Inc.">
//   *     (C) 1997, 2001-2016, All rights reserved.  
//   *     This software constitutes the trade secrets and confidential  and proprietary information of Johnson Controls, Inc.  
//   *     It is intended solely for use by Johnson Controls, Inc.  This code may not be copied or redistributed to 
//   *     third parties without prior written authorization from Johnson Controls, Inc.
//  </copyright>
//  <summary>
//    The Error.cs.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
#endregion

using System;

namespace HomeCinema.Entities
{
    public class Error: IEntityBase
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime DateCreated { get; set; }
    }
}