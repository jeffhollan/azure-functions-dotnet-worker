﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

﻿using Microsoft.Azure.Functions.Worker.Extensions.Abstractions;

namespace Microsoft.Azure.Functions.Worker
{
    public sealed class SignalROutputAttribute : OutputBindingAttribute
    {
        public SignalROutputAttribute()
        {
        }

        public string? ConnectionStringSetting { get; set; }

        public string? HubName { get; set; }
    }
}
