// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if REGISTRY_ASSEMBLY
using Microsoft.Win32.SafeHandles;
#else
using Internal.Win32.SafeHandles;
#endif
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Advapi32
    {
        // Note: RegCreateKeyEx won't set the last error on failure - it returns
        // an error code if it fails.
#if DLLIMPORTGENERATOR_ENABLED
        [GeneratedDllImport(Libraries.Advapi32, EntryPoint = "RegCreateKeyExW", CharSet = CharSet.Unicode, ExactSpelling = true)]
        internal static partial int RegCreateKeyEx(
#else
        [DllImport(Libraries.Advapi32, EntryPoint = "RegCreateKeyExW", BestFitMapping = false, CharSet = CharSet.Unicode, ExactSpelling = true)]
        internal static extern int RegCreateKeyEx(
#endif
            SafeRegistryHandle hKey,
            string lpSubKey,
            int Reserved,
            string? lpClass,
            int dwOptions,
            int samDesired,
            ref Interop.Kernel32.SECURITY_ATTRIBUTES secAttrs,
            out SafeRegistryHandle hkResult,
            out int lpdwDisposition);
    }
}
