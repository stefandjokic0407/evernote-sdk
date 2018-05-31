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
  /// If a Notebook contained in an Evernote Business account has been published
  /// the to business library, the Notebook will have a reference to one of these
  /// structures, which specifies how the Notebook will be represented in the
  /// library.
  /// 
  /// <dl>
  /// <dt>notebookDescription</dt>
  ///   <dd>A short description of the notebook's content that will be displayed
  ///       in the business library user interface. The description may not begin
  ///       or end with whitespace.
  ///   <br/>
  ///   Length: EDAM_BUSINESS_NOTEBOOK_DESCRIPTION_LEN_MIN -
  ///           EDAM_BUSINESS_NOTEBOOK_DESCRIPTION_LEN_MAX
  ///   <br/>
  ///   Regex:  EDAM_BUSINESS_NOTEBOOK_DESCRIPTION_REGEX
  ///   </dd>
  /// 
  /// <dt>privilege</dt>
  ///   <dd>The privileges that will be granted to users who join the notebook through
  ///       the business library.
  ///   </dd>
  /// 
  /// <dt>recommended</dt>
  ///   <dd>Whether the notebook should be "recommended" when displayed in the business
  ///       library user interface.
  ///   </dd>
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class BusinessNotebook : TBase
  {
    private string _notebookDescription;
    private SharedNotebookPrivilegeLevel _privilege;
    private bool _recommended;

    public string NotebookDescription
    {
      get
      {
        return _notebookDescription;
      }
      set
      {
        __isset.notebookDescription = true;
        this._notebookDescription = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="SharedNotebookPrivilegeLevel"/>
    /// </summary>
    public SharedNotebookPrivilegeLevel Privilege
    {
      get
      {
        return _privilege;
      }
      set
      {
        __isset.privilege = true;
        this._privilege = value;
      }
    }

    public bool Recommended
    {
      get
      {
        return _recommended;
      }
      set
      {
        __isset.recommended = true;
        this._recommended = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool notebookDescription;
      public bool privilege;
      public bool recommended;
    }

    public BusinessNotebook() {
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
              if (field.Type == TType.String) {
                NotebookDescription = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                Privilege = (SharedNotebookPrivilegeLevel)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Bool) {
                Recommended = iprot.ReadBool();
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
        TStruct struc = new TStruct("BusinessNotebook");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (NotebookDescription != null && __isset.notebookDescription) {
          field.Name = "notebookDescription";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(NotebookDescription);
          oprot.WriteFieldEnd();
        }
        if (__isset.privilege) {
          field.Name = "privilege";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Privilege);
          oprot.WriteFieldEnd();
        }
        if (__isset.recommended) {
          field.Name = "recommended";
          field.Type = TType.Bool;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Recommended);
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
      StringBuilder __sb = new StringBuilder("BusinessNotebook(");
      bool __first = true;
      if (NotebookDescription != null && __isset.notebookDescription) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NotebookDescription: ");
        __sb.Append(NotebookDescription);
      }
      if (__isset.privilege) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Privilege: ");
        __sb.Append(Privilege);
      }
      if (__isset.recommended) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Recommended: ");
        __sb.Append(Recommended);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
