﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Microsoft.VisualStudio.Services.Agent;
using Microsoft.VisualStudio.Services.Agent.Util;

namespace Agent.Sdk.Util
{
    public class ExceptionsUtil
    {
        public static void HandleSocketException(SocketException e, string url, ITraceWriter trace)
        {
            trace.Info("SocketException occurred.");
            trace.Info(e.Message);
            trace.Info($"Verify whether you have (network) access to { url }");
            trace.Info($"URLs the agent need communicate with - { BlobStoreWarningInfoProvider.GetAllowListLinkForCurrentPlatform() }");
        }
    }
}