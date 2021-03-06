﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.ManagementPack.ServiceBroker.Constants
{
    public static class SoProperties
    {
        public static class ProcessInstance
        {
            public const string ProcessName = "ProcessName";
            public const string StartSync = "StartSynchronous";
            public const string ProcessFolio = "Folio";
            public const string ProcInstId = "ProcInstId";
            public const string ProcessVersion = "ProcessVersion";
            public const string DataFieldName = "DataFieldName";
            public const string DataFieldValue = "DataFieldValue";
            public const string DataFieldType = "DataFieldType";
            public const string XmlFieldName = "XmlFieldName";
            public const string XmlFieldValue = "XmlFieldValue";
            public const string TargetProcVersion = "TargetProcVersion";
            public const string FromActName = "FromActName";
            public const string ToActName = "ToActName";

            public const string StartDate = "StartDate";
            public const string Status = "Status";
            public const string Originator = "Originator";
            public const string Version = "Version";
            public const string ExecutingVersion = "ExecutingVersion";
            public const string ProcSetId = "ProcSetId";
            public const string ProcId = "ProcId";
        }
        public static class Identity
        {
            public const string FQN = "FQN";
            public const string ResolveContainers = "ResolveContainers";
            public const string ResolveMembers = "ResolveMembers";
        }
    }
}
