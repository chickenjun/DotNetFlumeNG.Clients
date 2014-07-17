﻿// 
//     Copyright 2013 Mark Lamley
//  
//     Licensed under the Apache License, Version 2.0 (the "License");
//     you may not use this file except in compliance with the License.
//     You may obtain a copy of the License at
//  
//         http://www.apache.org/licenses/LICENSE-2.0
//  
//     Unless required by applicable law or agreed to in writing, software
//     distributed under the License is distributed on an "AS IS" BASIS,
//     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     See the License for the specific language governing permissions and
//     limitations under the License.

using System;
using DotNetFlumeNG.Client.LegacyThrift;
using NLog;
using NUnit.Framework;

namespace DotNetFlumeNG.Client.NLog.Tests.Thrift
{
    [TestFixture]
    public class ThriftClientTests
    {
        [SetUp]
        public void Setup()
        {
            _mockServer = new MockThriftServer();
        }

        [TearDown]
        public void TearDown()
        {
            _mockServer.Close();
        }

        private MockThriftServer _mockServer;

        [Test]
        public void Append_WithMockServer_Succeeds()
        {
            var logEventInfo = new LogEventInfo(LogLevel.Debug, "logger", "message");
            var nLogEventAdapter = new NLogEventAdapter("message", logEventInfo);
            using (var thriftClient = new LegacyThriftClient("localhost", 9090))
            {
                thriftClient.Append(nLogEventAdapter);
            }
        }

        [Test]
        public void Constructor_NoHost_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(
                () => new LegacyThriftClient(null, 50));
        }
    }
}