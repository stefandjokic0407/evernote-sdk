/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Evernote.EDAM.Type
{

  #if !SILVERLIGHT && !NETFX_CORE
  [Serializable]
  #endif
  public partial class LinkedNotebook : TBase
  {
    private string _shareName;
    private string _username;
    private string _shardId;
    private string _shareKey;
    private string _uri;
    private string _guid;
    private int _updateSequenceNum;
    private string _noteStoreUrl;
    private string _webApiUrlPrefix;

    public string ShareName
    {
      get
      {
        return _shareName;
      }
      set
      {
        __isset.shareName = true;
        this._shareName = value;
      }
    }

    public string Username
    {
      get
      {
        return _username;
      }
      set
      {
        __isset.username = true;
        this._username = value;
      }
    }

    public string ShardId
    {
      get
      {
        return _shardId;
      }
      set
      {
        __isset.shardId = true;
        this._shardId = value;
      }
    }

    public string ShareKey
    {
      get
      {
        return _shareKey;
      }
      set
      {
        __isset.shareKey = true;
        this._shareKey = value;
      }
    }

    public string Uri
    {
      get
      {
        return _uri;
      }
      set
      {
        __isset.uri = true;
        this._uri = value;
      }
    }

    public string Guid
    {
      get
      {
        return _guid;
      }
      set
      {
        __isset.guid = true;
        this._guid = value;
      }
    }

    public int UpdateSequenceNum
    {
      get
      {
        return _updateSequenceNum;
      }
      set
      {
        __isset.updateSequenceNum = true;
        this._updateSequenceNum = value;
      }
    }

    public string NoteStoreUrl
    {
      get
      {
        return _noteStoreUrl;
      }
      set
      {
        __isset.noteStoreUrl = true;
        this._noteStoreUrl = value;
      }
    }

    public string WebApiUrlPrefix
    {
      get
      {
        return _webApiUrlPrefix;
      }
      set
      {
        __isset.webApiUrlPrefix = true;
        this._webApiUrlPrefix = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT && !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool shareName;
      public bool username;
      public bool shardId;
      public bool shareKey;
      public bool uri;
      public bool guid;
      public bool updateSequenceNum;
      public bool noteStoreUrl;
      public bool webApiUrlPrefix;
    }

    public LinkedNotebook() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 2:
            if (field.Type == TType.String) {
              ShareName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Username = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              ShardId = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              ShareKey = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              Uri = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              Guid = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              UpdateSequenceNum = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              NoteStoreUrl = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              WebApiUrlPrefix = iprot.ReadString();
            } else { 
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("LinkedNotebook");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ShareName != null && __isset.shareName) {
        field.Name = "shareName";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ShareName);
        oprot.WriteFieldEnd();
      }
      if (Username != null && __isset.username) {
        field.Name = "username";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Username);
        oprot.WriteFieldEnd();
      }
      if (ShardId != null && __isset.shardId) {
        field.Name = "shardId";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ShardId);
        oprot.WriteFieldEnd();
      }
      if (ShareKey != null && __isset.shareKey) {
        field.Name = "shareKey";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ShareKey);
        oprot.WriteFieldEnd();
      }
      if (Uri != null && __isset.uri) {
        field.Name = "uri";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Uri);
        oprot.WriteFieldEnd();
      }
      if (Guid != null && __isset.guid) {
        field.Name = "guid";
        field.Type = TType.String;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Guid);
        oprot.WriteFieldEnd();
      }
      if (__isset.updateSequenceNum) {
        field.Name = "updateSequenceNum";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(UpdateSequenceNum);
        oprot.WriteFieldEnd();
      }
      if (NoteStoreUrl != null && __isset.noteStoreUrl) {
        field.Name = "noteStoreUrl";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(NoteStoreUrl);
        oprot.WriteFieldEnd();
      }
      if (WebApiUrlPrefix != null && __isset.webApiUrlPrefix) {
        field.Name = "webApiUrlPrefix";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(WebApiUrlPrefix);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("LinkedNotebook(");
      sb.Append("ShareName: ");
      sb.Append(ShareName);
      sb.Append(",Username: ");
      sb.Append(Username);
      sb.Append(",ShardId: ");
      sb.Append(ShardId);
      sb.Append(",ShareKey: ");
      sb.Append(ShareKey);
      sb.Append(",Uri: ");
      sb.Append(Uri);
      sb.Append(",Guid: ");
      sb.Append(Guid);
      sb.Append(",UpdateSequenceNum: ");
      sb.Append(UpdateSequenceNum);
      sb.Append(",NoteStoreUrl: ");
      sb.Append(NoteStoreUrl);
      sb.Append(",WebApiUrlPrefix: ");
      sb.Append(WebApiUrlPrefix);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
