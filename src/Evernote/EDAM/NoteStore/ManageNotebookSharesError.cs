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

namespace Evernote.EDAM.NoteStore
{

  /// <summary>
  /// A structure to capture certain errors that occurred during a call
  /// to manageNotebookShares.  That method can be run best-effort,
  /// meaning that some change requests can be applied while others fail.
  /// Note that some errors such as system errors will still fail the
  /// entire transaction regardless of running best effort.  When some
  /// change requests do not succeed, the error conditions are captured
  /// in instances of this class, captured by the identity of the share
  /// relationship and one of the exception fields.
  /// 
  /// <dl>
  /// <dt>userIdentity</dt>
  /// <dd>The identity of the share relationship whose update encountered
  /// an error.</dd>
  /// 
  /// <dt>userException</dt>
  /// <dd>If the error is represented as an EDAMUserException that would
  /// have otherwise been thrown without best-effort execution.  Only one
  /// exception field will be set.</dd>
  /// 
  /// <dt>notFoundException</dt>
  /// <dd>If the error is represented as an EDAMNotFoundException that would
  /// have otherwise been thrown without best-effort execution.  Only one
  /// exception field will be set.</dd>
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ManageNotebookSharesError : TBase
  {
    private Evernote.EDAM.Type.UserIdentity _userIdentity;
    private Evernote.EDAM.Error.EDAMUserException _userException;
    private Evernote.EDAM.Error.EDAMNotFoundException _notFoundException;

    public Evernote.EDAM.Type.UserIdentity UserIdentity
    {
      get
      {
        return _userIdentity;
      }
      set
      {
        __isset.userIdentity = true;
        this._userIdentity = value;
      }
    }

    public Evernote.EDAM.Error.EDAMUserException UserException
    {
      get
      {
        return _userException;
      }
      set
      {
        __isset.userException = true;
        this._userException = value;
      }
    }

    public Evernote.EDAM.Error.EDAMNotFoundException NotFoundException
    {
      get
      {
        return _notFoundException;
      }
      set
      {
        __isset.notFoundException = true;
        this._notFoundException = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool userIdentity;
      public bool userException;
      public bool notFoundException;
    }

    public ManageNotebookSharesError() {
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
              if (field.Type == TType.Struct) {
                UserIdentity = new Evernote.EDAM.Type.UserIdentity();
                UserIdentity.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                UserException = new Evernote.EDAM.Error.EDAMUserException();
                UserException.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                NotFoundException = new Evernote.EDAM.Error.EDAMNotFoundException();
                NotFoundException.Read(iprot);
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
        TStruct struc = new TStruct("ManageNotebookSharesError");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (UserIdentity != null && __isset.userIdentity) {
          field.Name = "userIdentity";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          UserIdentity.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (UserException != null && __isset.userException) {
          field.Name = "userException";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          UserException.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (NotFoundException != null && __isset.notFoundException) {
          field.Name = "notFoundException";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          NotFoundException.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("ManageNotebookSharesError(");
      bool __first = true;
      if (UserIdentity != null && __isset.userIdentity) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UserIdentity: ");
        __sb.Append(UserIdentity== null ? "<null>" : UserIdentity.ToString());
      }
      if (UserException != null && __isset.userException) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UserException: ");
        __sb.Append(UserException== null ? "<null>" : UserException.ToString());
      }
      if (NotFoundException != null && __isset.notFoundException) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NotFoundException: ");
        __sb.Append(NotFoundException== null ? "<null>" : NotFoundException.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
