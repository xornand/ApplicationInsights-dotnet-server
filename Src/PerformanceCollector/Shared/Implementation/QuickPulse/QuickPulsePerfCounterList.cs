﻿namespace Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.Implementation.QuickPulse
{
    using System;

    /// <summary>
    /// Represents a list of performance counters to collect for QPS.
    /// </summary>
    internal static class QuickPulsePerfCounterList
    {
        public static Tuple<QuickPulsePerfCounters, string>[] CountersToCollect
            =>
                new[]
                    {
                        Tuple.Create(QuickPulsePerfCounters.PerfIisQueueSize, @"\ASP.NET Applications(__Total__)\Requests In Application Queue"),
                        Tuple.Create(QuickPulsePerfCounters.PerfCpuUtilization, @"\Memory\Committed Bytes"),
                        Tuple.Create(QuickPulsePerfCounters.PerfMemoryInBytes, @"\Processor(_Total)\% Processor Time")
                    };
    }
}