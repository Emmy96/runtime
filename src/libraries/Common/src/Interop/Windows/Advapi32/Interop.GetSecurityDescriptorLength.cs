// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Advapi32
    {
        [DllImport(Interop.Libraries.Advapi32, EntryPoint = "GetSecurityDescriptorLength", CallingConvention = CallingConvention.Winapi,
            CharSet = CharSet.Unicode, ExactSpelling = true)]
        internal static extern /*DWORD*/ uint GetSecurityDescriptorLength(IntPtr byteArray);
    }
}
