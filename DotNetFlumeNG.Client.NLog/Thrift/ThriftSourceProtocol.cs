/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DotNetFlumeNG.Client.Thrift;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace DotNetFlumeNG.Client.Thrift
{
    public partial class ThriftSourceProtocol
    {
        public interface Iface
        {
            Status append(ThriftFlumeEvent evt);
#if SILVERLIGHT
    IAsyncResult Begin_append(AsyncCallback callback, object state, ThriftFlumeEvent evt);
    Status End_append(IAsyncResult asyncResult);
#endif
            Status appendBatch(List<ThriftFlumeEvent> evts);
#if SILVERLIGHT
    IAsyncResult Begin_appendBatch(AsyncCallback callback, object state, List<ThriftFlumeEvent> evts);
    Status End_appendBatch(IAsyncResult asyncResult);
#endif
        }

        public class Client : IDisposable, Iface
        {
            public Client(TProtocol prot)
                : this(prot, prot)
            {
            }

            public Client(TProtocol iprot, TProtocol oprot)
            {
                iprot_ = iprot;
                oprot_ = oprot;
            }

            protected TProtocol iprot_;
            protected TProtocol oprot_;
            protected int seqid_;

            public TProtocol InputProtocol
            {
                get { return iprot_; }
            }

            public TProtocol OutputProtocol
            {
                get { return oprot_; }
            }


            #region " IDisposable Support "

            private bool _IsDisposed;

            // IDisposable
            public void Dispose()
            {
                Dispose(true);
            }


            protected virtual void Dispose(bool disposing)
            {
                if (!_IsDisposed)
                {
                    if (disposing)
                    {
                        if (iprot_ != null)
                        {
                            ((IDisposable) iprot_).Dispose();
                        }
                        if (oprot_ != null)
                        {
                            ((IDisposable) oprot_).Dispose();
                        }
                    }
                }
                _IsDisposed = true;
            }

            #endregion



#if SILVERLIGHT
    public IAsyncResult Begin_append(AsyncCallback callback, object state, ThriftFlumeEvent evt)
    {
      return send_append(callback, state, evt);
    }

    public Status End_append(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      return recv_append();
    }

#endif

            public Status append(ThriftFlumeEvent evt)
            {
#if !SILVERLIGHT
                send_append(evt);
                return recv_append();

#else
      var asyncResult = Begin_append(null, null, evt);
      return End_append(asyncResult);

#endif
            }

#if SILVERLIGHT
    public IAsyncResult send_append(AsyncCallback callback, object state, ThriftFlumeEvent evt)
#else
            public void send_append(ThriftFlumeEvent evt)
#endif
            {
                oprot_.WriteMessageBegin(new TMessage("append", TMessageType.Call, seqid_));
                append_args args = new append_args();
                args.Evt = evt;
                args.Write(oprot_);
                oprot_.WriteMessageEnd();
#if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
#else
                oprot_.Transport.Flush();
#endif
            }

            public Status recv_append()
            {
                TMessage msg = iprot_.ReadMessageBegin();
                if (msg.Type == TMessageType.Exception)
                {
                    TApplicationException x = TApplicationException.Read(iprot_);
                    iprot_.ReadMessageEnd();
                    throw x;
                }
                append_result result = new append_result();
                result.Read(iprot_);
                iprot_.ReadMessageEnd();
                if (result.__isset.success)
                {
                    return result.Success;
                }
                throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "append failed: unknown result");
            }


#if SILVERLIGHT
    public IAsyncResult Begin_appendBatch(AsyncCallback callback, object state, List<ThriftFlumeEvent> evts)
    {
      return send_appendBatch(callback, state, evts);
    }

    public Status End_appendBatch(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      return recv_appendBatch();
    }

#endif

            public Status appendBatch(List<ThriftFlumeEvent> evts)
            {
#if !SILVERLIGHT
                send_appendBatch(evts);
                return recv_appendBatch();

#else
      var asyncResult = Begin_appendBatch(null, null, evts);
      return End_appendBatch(asyncResult);

#endif
            }

#if SILVERLIGHT
    public IAsyncResult send_appendBatch(AsyncCallback callback, object state, List<ThriftFlumeEvent> evts)
#else
            public void send_appendBatch(List<ThriftFlumeEvent> evts)
#endif
            {
                oprot_.WriteMessageBegin(new TMessage("appendBatch", TMessageType.Call, seqid_));
                appendBatch_args args = new appendBatch_args();
                args.Evts = evts;
                args.Write(oprot_);
                oprot_.WriteMessageEnd();
#if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
#else
                oprot_.Transport.Flush();
#endif
            }

            public Status recv_appendBatch()
            {
                TMessage msg = iprot_.ReadMessageBegin();
                if (msg.Type == TMessageType.Exception)
                {
                    TApplicationException x = TApplicationException.Read(iprot_);
                    iprot_.ReadMessageEnd();
                    throw x;
                }
                appendBatch_result result = new appendBatch_result();
                result.Read(iprot_);
                iprot_.ReadMessageEnd();
                if (result.__isset.success)
                {
                    return result.Success;
                }
                throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "appendBatch failed: unknown result");
            }

        }

        public class Processor : TProcessor
        {
            public Processor(Iface iface)
            {
                iface_ = iface;
                processMap_["append"] = append_Process;
                processMap_["appendBatch"] = appendBatch_Process;
            }

            protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);

            private Iface iface_;
            protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

            public bool Process(TProtocol iprot, TProtocol oprot)
            {
                try
                {
                    TMessage msg = iprot.ReadMessageBegin();
                    ProcessFunction fn;
                    processMap_.TryGetValue(msg.Name, out fn);
                    if (fn == null)
                    {
                        TProtocolUtil.Skip(iprot, TType.Struct);
                        iprot.ReadMessageEnd();
                        TApplicationException x = new TApplicationException(TApplicationException.ExceptionType.UnknownMethod,
                                                                            "Invalid method name: '" + msg.Name + "'");
                        oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
                        x.Write(oprot);
                        oprot.WriteMessageEnd();
                        oprot.Transport.Flush();
                        return true;
                    }
                    fn(msg.SeqID, iprot, oprot);
                }
                catch (IOException)
                {
                    return false;
                }
                return true;
            }

            public void append_Process(int seqid, TProtocol iprot, TProtocol oprot)
            {
                append_args args = new append_args();
                args.Read(iprot);
                iprot.ReadMessageEnd();
                append_result result = new append_result();
                result.Success = iface_.append(args.Evt);
                oprot.WriteMessageBegin(new TMessage("append", TMessageType.Reply, seqid));
                result.Write(oprot);
                oprot.WriteMessageEnd();
                oprot.Transport.Flush();
            }

            public void appendBatch_Process(int seqid, TProtocol iprot, TProtocol oprot)
            {
                appendBatch_args args = new appendBatch_args();
                args.Read(iprot);
                iprot.ReadMessageEnd();
                appendBatch_result result = new appendBatch_result();
                result.Success = iface_.appendBatch(args.Evts);
                oprot.WriteMessageBegin(new TMessage("appendBatch", TMessageType.Reply, seqid));
                result.Write(oprot);
                oprot.WriteMessageEnd();
                oprot.Transport.Flush();
            }

        }


#if !SILVERLIGHT
        [Serializable]
#endif
        public partial class append_args : TBase
        {
            private ThriftFlumeEvent _evt;

            public ThriftFlumeEvent Evt
            {
                get { return _evt; }
                set
                {
                    __isset.evt = true;
                    this._evt = value;
                }
            }


            public Isset __isset;
#if !SILVERLIGHT
            [Serializable]
#endif
            public struct Isset
            {
                public bool evt;
            }

            public append_args()
            {
            }

            public void Read(TProtocol iprot)
            {
                TField field;
                iprot.ReadStructBegin();
                while (true)
                {
                    field = iprot.ReadFieldBegin();
                    if (field.Type == TType.Stop)
                    {
                        break;
                    }
                    switch (field.ID)
                    {
                        case 1:
                            if (field.Type == TType.Struct)
                            {
                                Evt = new ThriftFlumeEvent();
                                Evt.Read(iprot);
                            }
                            else
                            {
                                TProtocolUtil.Skip(iprot, field.Type);
                            }
                            break;
                        default:
                            TProtocolUtil.Skip(iprot, field.Type);
                            break;
                    }
                    iprot.ReadFieldEnd();
                }
                iprot.ReadStructEnd();
            }

            public void Write(TProtocol oprot)
            {
                TStruct struc = new TStruct("append_args");
                oprot.WriteStructBegin(struc);
                TField field = new TField();
                if (Evt != null && __isset.evt)
                {
                    field.Name = "evt";
                    field.Type = TType.Struct;
                    field.ID = 1;
                    oprot.WriteFieldBegin(field);
                    Evt.Write(oprot);
                    oprot.WriteFieldEnd();
                }
                oprot.WriteFieldStop();
                oprot.WriteStructEnd();
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder("append_args(");
                sb.Append("Evt: ");
                sb.Append(Evt == null ? "<null>" : Evt.ToString());
                sb.Append(")");
                return sb.ToString();
            }

        }


#if !SILVERLIGHT
        [Serializable]
#endif
        public partial class append_result : TBase
        {
            private Status _success;

            /// <summary>
            /// 
            /// <seealso cref="Status"/>
            /// </summary>
            public Status Success
            {
                get { return _success; }
                set
                {
                    __isset.success = true;
                    this._success = value;
                }
            }


            public Isset __isset;
#if !SILVERLIGHT
            [Serializable]
#endif
            public struct Isset
            {
                public bool success;
            }

            public append_result()
            {
            }

            public void Read(TProtocol iprot)
            {
                TField field;
                iprot.ReadStructBegin();
                while (true)
                {
                    field = iprot.ReadFieldBegin();
                    if (field.Type == TType.Stop)
                    {
                        break;
                    }
                    switch (field.ID)
                    {
                        case 0:
                            if (field.Type == TType.I32)
                            {
                                Success = (Status) iprot.ReadI32();
                            }
                            else
                            {
                                TProtocolUtil.Skip(iprot, field.Type);
                            }
                            break;
                        default:
                            TProtocolUtil.Skip(iprot, field.Type);
                            break;
                    }
                    iprot.ReadFieldEnd();
                }
                iprot.ReadStructEnd();
            }

            public void Write(TProtocol oprot)
            {
                TStruct struc = new TStruct("append_result");
                oprot.WriteStructBegin(struc);
                TField field = new TField();

                if (this.__isset.success)
                {
                    field.Name = "Success";
                    field.Type = TType.I32;
                    field.ID = 0;
                    oprot.WriteFieldBegin(field);
                    oprot.WriteI32((int) Success);
                    oprot.WriteFieldEnd();
                }
                oprot.WriteFieldStop();
                oprot.WriteStructEnd();
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder("append_result(");
                sb.Append("Success: ");
                sb.Append(Success);
                sb.Append(")");
                return sb.ToString();
            }

        }


#if !SILVERLIGHT
        [Serializable]
#endif
        public partial class appendBatch_args : TBase
        {
            private List<ThriftFlumeEvent> _evts;

            public List<ThriftFlumeEvent> Evts
            {
                get { return _evts; }
                set
                {
                    __isset.evts = true;
                    this._evts = value;
                }
            }


            public Isset __isset;
#if !SILVERLIGHT
            [Serializable]
#endif
            public struct Isset
            {
                public bool evts;
            }

            public appendBatch_args()
            {
            }

            public void Read(TProtocol iprot)
            {
                TField field;
                iprot.ReadStructBegin();
                while (true)
                {
                    field = iprot.ReadFieldBegin();
                    if (field.Type == TType.Stop)
                    {
                        break;
                    }
                    switch (field.ID)
                    {
                        case 1:
                            if (field.Type == TType.List)
                            {
                                {
                                    Evts = new List<ThriftFlumeEvent>();
                                    TList _list5 = iprot.ReadListBegin();
                                    for (int _i6 = 0; _i6 < _list5.Count; ++_i6)
                                    {
                                        ThriftFlumeEvent _elem7 = new ThriftFlumeEvent();
                                        _elem7 = new ThriftFlumeEvent();
                                        _elem7.Read(iprot);
                                        Evts.Add(_elem7);
                                    }
                                    iprot.ReadListEnd();
                                }
                            }
                            else
                            {
                                TProtocolUtil.Skip(iprot, field.Type);
                            }
                            break;
                        default:
                            TProtocolUtil.Skip(iprot, field.Type);
                            break;
                    }
                    iprot.ReadFieldEnd();
                }
                iprot.ReadStructEnd();
            }

            public void Write(TProtocol oprot)
            {
                TStruct struc = new TStruct("appendBatch_args");
                oprot.WriteStructBegin(struc);
                TField field = new TField();
                if (Evts != null && __isset.evts)
                {
                    field.Name = "evts";
                    field.Type = TType.List;
                    field.ID = 1;
                    oprot.WriteFieldBegin(field);
                    {
                        oprot.WriteListBegin(new TList(TType.Struct, Evts.Count));
                        foreach (ThriftFlumeEvent _iter8 in Evts)
                        {
                            _iter8.Write(oprot);
                        }
                        oprot.WriteListEnd();
                    }
                    oprot.WriteFieldEnd();
                }
                oprot.WriteFieldStop();
                oprot.WriteStructEnd();
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder("appendBatch_args(");
                sb.Append("Evts: ");
                sb.Append(Evts);
                sb.Append(")");
                return sb.ToString();
            }

        }


#if !SILVERLIGHT
        [Serializable]
#endif
        public partial class appendBatch_result : TBase
        {
            private Status _success;

            /// <summary>
            /// 
            /// <seealso cref="Status"/>
            /// </summary>
            public Status Success
            {
                get { return _success; }
                set
                {
                    __isset.success = true;
                    this._success = value;
                }
            }


            public Isset __isset;
#if !SILVERLIGHT
            [Serializable]
#endif
            public struct Isset
            {
                public bool success;
            }

            public appendBatch_result()
            {
            }

            public void Read(TProtocol iprot)
            {
                TField field;
                iprot.ReadStructBegin();
                while (true)
                {
                    field = iprot.ReadFieldBegin();
                    if (field.Type == TType.Stop)
                    {
                        break;
                    }
                    switch (field.ID)
                    {
                        case 0:
                            if (field.Type == TType.I32)
                            {
                                Success = (Status) iprot.ReadI32();
                            }
                            else
                            {
                                TProtocolUtil.Skip(iprot, field.Type);
                            }
                            break;
                        default:
                            TProtocolUtil.Skip(iprot, field.Type);
                            break;
                    }
                    iprot.ReadFieldEnd();
                }
                iprot.ReadStructEnd();
            }

            public void Write(TProtocol oprot)
            {
                TStruct struc = new TStruct("appendBatch_result");
                oprot.WriteStructBegin(struc);
                TField field = new TField();

                if (this.__isset.success)
                {
                    field.Name = "Success";
                    field.Type = TType.I32;
                    field.ID = 0;
                    oprot.WriteFieldBegin(field);
                    oprot.WriteI32((int) Success);
                    oprot.WriteFieldEnd();
                }
                oprot.WriteFieldStop();
                oprot.WriteStructEnd();
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder("appendBatch_result(");
                sb.Append("Success: ");
                sb.Append(Success);
                sb.Append(")");
                return sb.ToString();
            }

        }

    }
}