// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class libcurl
    {
        [DllImport(Interop.Libraries.LibCurl)]
        public static extern int curl_global_init(
            long flags);

        [DllImport(Interop.Libraries.LibCurl)]
        public static extern void curl_global_cleanup();

        [DllImport(Interop.Libraries.LibCurl)]
        public static extern IntPtr curl_version_info(int curlVersionStamp);
    }
}
