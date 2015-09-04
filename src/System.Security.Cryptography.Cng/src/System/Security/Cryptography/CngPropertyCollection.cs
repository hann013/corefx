// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace System.Security.Cryptography
{
    public sealed class CngPropertyCollection : Collection<CngProperty>
    {
        public CngPropertyCollection()
            : base()
        {
        }
    }
}

