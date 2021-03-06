// Copyright (c) 2018 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: InitializeCacheResponse.proto
// Note: requires additional types generated from: ShutDownServerInfo.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InitializeCacheResponse")]
  public partial class InitializeCacheResponse : global::ProtoBuf.IExtensible
  {
    public InitializeCacheResponse() {}
    

    private string _cacheType = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cacheType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cacheType
    {
      get { return _cacheType; }
      set { _cacheType = value; }
    }

    private string _targetCacheUniqueID = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"targetCacheUniqueID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string targetCacheUniqueID
    {
      get { return _targetCacheUniqueID; }
      set { _targetCacheUniqueID = value; }
    }

    private bool _isPersistenceEnabled = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"isPersistenceEnabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool isPersistenceEnabled
    {
      get { return _isPersistenceEnabled; }
      set { _isPersistenceEnabled = value; }
    }

    private int _persistenceInterval = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"persistenceInterval", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int persistenceInterval
    {
      get { return _persistenceInterval; }
      set { _persistenceInterval = value; }
    }

    private bool _isShutDownProcessEnabled = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"isShutDownProcessEnabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool isShutDownProcessEnabled
    {
      get { return _isShutDownProcessEnabled; }
      set { _isShutDownProcessEnabled = value; }
    }
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.ShutDownServerInfo> _shutDownServerInfo = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.ShutDownServerInfo>();
    [global::ProtoBuf.ProtoMember(6, Name=@"shutDownServerInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.ShutDownServerInfo> shutDownServerInfo
    {
      get { return _shutDownServerInfo; }
    }
  

    private bool _requestLoggingEnabled = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"requestLoggingEnabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool requestLoggingEnabled
    {
      get { return _requestLoggingEnabled; }
      set { _requestLoggingEnabled = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}