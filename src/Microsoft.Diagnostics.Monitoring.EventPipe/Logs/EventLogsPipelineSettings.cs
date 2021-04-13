﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Diagnostics.Monitoring.EventPipe
{
    internal class EventLogsPipelineSettings : EventSourcePipelineSettings
    {
        public LogLevel LogLevel { get; set; }

        //This setting will set the levels to application default.
        public bool UseAppFilters { get; set; }
    }
}
