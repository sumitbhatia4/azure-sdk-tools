﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.Test.Common
{
    using System;
    using Commands.Utilities.Common;
    using Microsoft.WindowsAzure.Management.Utilities.Common;
    using Microsoft.WindowsAzure.Commands.Utilities.Properties;
    using VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GeneralTests
    {
        private const string _publishSettingsUrl = "http://manage.windowsazure.com/";
        private const string _azureHostNameSuffix = "the suffix";

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            // Set test environment variables
            Environment.SetEnvironmentVariable(Resources.PublishSettingsUrlEnv, _publishSettingsUrl);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            // Delete test environment variables
            Environment.SetEnvironmentVariable(Resources.PublishSettingsUrlEnv, null);
        }

        [TestMethod]
        public void TestBlobEndpointUri()
        {
            string accountName = "azure awesome account";
            string expected = string.Format(Resources.BlobEndpointUri, accountName);
            string actual = General.BlobEndpointUri(accountName);

            Assert.AreEqual<string>(expected, actual);
        }
    }
}