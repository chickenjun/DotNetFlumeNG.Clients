// 
//    Copyright 2013 Mark Lamley
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
        Target = "DotNetFlumeNG.Client.Thrift")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
        Target = "DotNetFlumeNG.Client.NLog")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1050:DeclareTypesInNamespaces", Scope = "type", Target = "EventStatus")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ACK", Scope = "member",
        Target = "EventStatus.#ACK")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "COMMITED",
        Scope = "member", Target = "EventStatus.#COMMITED")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ERR", Scope = "member",
        Target = "EventStatus.#ERR")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "INFO", Scope = "member"
        , Target = "Priority.#INFO")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DEBUG",
        Scope = "member", Target = "Priority.#DEBUG")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "TRACE",
        Scope = "member", Target = "Priority.#TRACE")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2215:Dispose methods should call base class dispose", Scope = "member",
        Target = "DotNetFlumeNG.Client.Thrift.ThriftClientPooled.#Dispose(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member"
        , Target = "ThriftFlumeEvent.#Read(Thrift.Protocol.TProtocol)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member"
        , Target = "ThriftFlumeEvent.#Write(Thrift.Protocol.TProtocol)")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member",
        Target = "ThriftFlumeEventServer+Client.#InputProtocol")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member",
        Target = "ThriftFlumeEventServer+Client.#OutputProtocol")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type",
        Target = "ThriftFlumeEventServer+Processor")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member"
        , Target = "ThriftFlumeEventServer+Processor.#Process(Thrift.Protocol.TProtocol,Thrift.Protocol.TProtocol)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member"
        , Target = "ThriftFlumeEventServer+Processor.#Process(Thrift.Protocol.TProtocol,Thrift.Protocol.TProtocol)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member"
        , Target = "ThriftFlumeEventServer+append_args.#Read(Thrift.Protocol.TProtocol)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member"
        , Target = "ThriftFlumeEventServer+append_args.#Write(Thrift.Protocol.TProtocol)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member"
        , Target = "ThriftFlumeEventServer+close_args.#Read(Thrift.Protocol.TProtocol)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member"
        , Target = "ThriftFlumeEventServer+close_args.#Write(Thrift.Protocol.TProtocol)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member"
        , Target = "ThriftFlumeEventServer+close_result.#Read(Thrift.Protocol.TProtocol)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member"
        , Target = "ThriftFlumeEventServer+close_result.#Write(Thrift.Protocol.TProtocol)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1044:PropertiesShouldNotBeWriteOnly", Scope = "member",
        Target = "DotNetFlumeNG.Client.Core.LogEvent.#Timestamp")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member",
        Target = "DotNetFlumeNG.Client.Core.LogEvent.#Nanos")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member",
        Target = "DotNetFlumeNG.Client.Core.LogEvent.#Host")]
[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly: SuppressMessage("Microsoft.Design", "CA1050:DeclareTypesInNamespaces", Scope = "type", Target = "Priority")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FATAL",
        Scope = "member", Target = "Priority.#FATAL")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ERROR",
        Scope = "member", Target = "Priority.#ERROR")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "WARN", Scope = "member"
        , Target = "Priority.#WARN")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LIFO", Scope = "member"
        , Target = "DotNetFlumeNG.Client.Core.AccessMode.#LIFO")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FIFO", Scope = "member"
        , Target = "DotNetFlumeNG.Client.Core.AccessMode.#FIFO")]