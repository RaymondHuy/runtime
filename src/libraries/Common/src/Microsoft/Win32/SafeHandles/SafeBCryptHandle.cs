// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

using NTSTATUS = Interop.BCrypt.NTSTATUS;

namespace Microsoft.Win32.SafeHandles
{
    internal abstract class SafeBCryptHandle : SafeHandle, IDisposable
    {
        protected SafeBCryptHandle()
            : base(IntPtr.Zero, true)

        {
        }

        public sealed override bool IsInvalid
        {
            get
            {
                return handle == IntPtr.Zero;
            }
        }

        protected abstract override bool ReleaseHandle();
    }
}
