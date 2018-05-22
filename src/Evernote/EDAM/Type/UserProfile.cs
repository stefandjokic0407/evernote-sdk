/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Evernote.EDAM.Type
{

  /// <summary>
  /// This structure represents profile information for a user in a business.
  /// 
  /// <dl>
  /// <dt>id</dt>
  /// <dd>The numeric identifier that uniquely identifies a user.</dd>
  /// 
  /// <dt>name</dt>
  /// <dd>The full name of the user.</dd>
  /// 
  /// <dt>email</dt>
  /// <dd>The user's business email address. If the user has not registered their business
  ///   email address, this field will be empty.
  /// </dd>
  /// 
  /// <dt>username</dt>
  /// <dd>The user's Evernote username.</dd>
  /// 
  /// <dt>attributes</dt>
  /// <dd>The user's business specific attributes.</dd>
  /// 
  /// <dt>joined</dt>
  /// <dd>The time when the user joined the business</dd>
  /// 
  /// <dt>photoLastUpdated</dt>
  /// <dd>The time when the user's profile photo was most recently updated</dd>
  /// 
  /// <dt>photoUrl</dt>
  /// <dd>A URL identifying a copy of the user's current profile photo</dd>
  /// 
  /// <dt>role</dt>
  /// <dd>The BusinessUserRole for the user</dd>
  /// 
  /// <dt>status</dt>
  /// <dd>The BusinessUserStatus for the user</dd>
  /// 
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class UserProfile : TBase
  {
    private int _id;
    private string _name;
    private string _email;
    private string _username;
    private BusinessUserAttributes _attributes;
    private long _joined;
    private long _photoLastUpdated;
    private string _photoUrl;
    private BusinessUserRole _role;
    private BusinessUserStatus _status;

    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public string Email
    {
      get
      {
        return _email;
      }
      set
      {
        __isset.email = true;
        this._email = value;
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

    public BusinessUserAttributes Attributes
    {
      get
      {
        return _attributes;
      }
      set
      {
        __isset.attributes = true;
        this._attributes = value;
      }
    }

    public long Joined
    {
      get
      {
        return _joined;
      }
      set
      {
        __isset.joined = true;
        this._joined = value;
      }
    }

    public long PhotoLastUpdated
    {
      get
      {
        return _photoLastUpdated;
      }
      set
      {
        __isset.photoLastUpdated = true;
        this._photoLastUpdated = value;
      }
    }

    public string PhotoUrl
    {
      get
      {
        return _photoUrl;
      }
      set
      {
        __isset.photoUrl = true;
        this._photoUrl = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="BusinessUserRole"/>
    /// </summary>
    public BusinessUserRole Role
    {
      get
      {
        return _role;
      }
      set
      {
        __isset.role = true;
        this._role = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="BusinessUserStatus"/>
    /// </summary>
    public BusinessUserStatus Status
    {
      get
      {
        return _status;
      }
      set
      {
        __isset.status = true;
        this._status = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
      public bool name;
      public bool email;
      public bool username;
      public bool attributes;
      public bool joined;
      public bool photoLastUpdated;
      public bool photoUrl;
      public bool role;
      public bool status;
    }

    public UserProfile() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
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
            case 1:
              if (field.Type == TType.I32) {
                Id = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Email = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                Username = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Struct) {
                Attributes = new BusinessUserAttributes();
                Attributes.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I64) {
                Joined = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.I64) {
                PhotoLastUpdated = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.String) {
                PhotoUrl = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.I32) {
                Role = (BusinessUserRole)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.I32) {
                Status = (BusinessUserStatus)iprot.ReadI32();
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
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("UserProfile");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.id) {
          field.Name = "id";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Id);
          oprot.WriteFieldEnd();
        }
        if (Name != null && __isset.name) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (Email != null && __isset.email) {
          field.Name = "email";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Email);
          oprot.WriteFieldEnd();
        }
        if (Username != null && __isset.username) {
          field.Name = "username";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Username);
          oprot.WriteFieldEnd();
        }
        if (Attributes != null && __isset.attributes) {
          field.Name = "attributes";
          field.Type = TType.Struct;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          Attributes.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.joined) {
          field.Name = "joined";
          field.Type = TType.I64;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Joined);
          oprot.WriteFieldEnd();
        }
        if (__isset.photoLastUpdated) {
          field.Name = "photoLastUpdated";
          field.Type = TType.I64;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(PhotoLastUpdated);
          oprot.WriteFieldEnd();
        }
        if (PhotoUrl != null && __isset.photoUrl) {
          field.Name = "photoUrl";
          field.Type = TType.String;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(PhotoUrl);
          oprot.WriteFieldEnd();
        }
        if (__isset.role) {
          field.Name = "role";
          field.Type = TType.I32;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Role);
          oprot.WriteFieldEnd();
        }
        if (__isset.status) {
          field.Name = "status";
          field.Type = TType.I32;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Status);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("UserProfile(");
      bool __first = true;
      if (__isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (Name != null && __isset.name) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Name: ");
        __sb.Append(Name);
      }
      if (Email != null && __isset.email) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Email: ");
        __sb.Append(Email);
      }
      if (Username != null && __isset.username) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Username: ");
        __sb.Append(Username);
      }
      if (Attributes != null && __isset.attributes) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Attributes: ");
        __sb.Append(Attributes== null ? "<null>" : Attributes.ToString());
      }
      if (__isset.joined) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Joined: ");
        __sb.Append(Joined);
      }
      if (__isset.photoLastUpdated) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PhotoLastUpdated: ");
        __sb.Append(PhotoLastUpdated);
      }
      if (PhotoUrl != null && __isset.photoUrl) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PhotoUrl: ");
        __sb.Append(PhotoUrl);
      }
      if (__isset.role) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Role: ");
        __sb.Append(Role);
      }
      if (__isset.status) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Status: ");
        __sb.Append(Status);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
