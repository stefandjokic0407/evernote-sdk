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
  /// Describes the association between a Notebook and an Evernote User who is
  /// a member of that notebook.
  /// 
  /// <dl>
  /// <dt>displayName</dt>
  /// <dd>The string that clients should show to users to represent this
  /// member.</dd>
  /// 
  /// <dt>recipientUserId</dt>
  /// <dd>The Evernote User ID of the recipient of this notebook share.
  /// </dd>
  /// 
  /// <dt>bestPrivilege</dt>
  /// <dd>The privilege at which the member can access the notebook,
  /// which is the best privilege granted either individually or to a
  /// group to which a member belongs, such as a business.  This field is
  /// used by the service to convey information to the user, so clients
  /// should treat it as read-only.</dd>
  /// 
  /// <dt>individualPrivilege</dt>
  /// <dd>The individually granted privilege for the member, which does
  /// not take GROUP privileges into account.  This value may be unset if
  /// only a group-assigned privilege has been granted to the member.
  /// This value can be managed by others with sufficient rights using
  /// the manageNotebookShares method.  The valid values that clients
  /// should present to users for selection are given via the the
  /// 'restrictions' field.</dd>
  /// 
  /// <dt>restrictions</dt>
  /// <dd>The restrictions on which privileges may be individually
  /// assigned to the recipient of this share relationship.</dd>
  /// 
  /// <dt>sharerUserId</dt>
  /// <dd>The user id of the user who most recently shared the notebook
  /// to this user. This field is currently unset for a MemberShareRelationship
  /// created by joining a notebook that has been published to the business
  /// (MemberShareRelationships where the individual privilege is unset).
  /// This field is used by the service to convey information to the user, so
  /// clients should treat it as read-only.
  /// </dd>
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class MemberShareRelationship : TBase
  {
    private string _displayName;
    private int _recipientUserId;
    private ShareRelationshipPrivilegeLevel _bestPrivilege;
    private ShareRelationshipPrivilegeLevel _individualPrivilege;
    private ShareRelationshipRestrictions _restrictions;
    private int _sharerUserId;

    public string DisplayName
    {
      get
      {
        return _displayName;
      }
      set
      {
        __isset.displayName = true;
        this._displayName = value;
      }
    }

    public int RecipientUserId
    {
      get
      {
        return _recipientUserId;
      }
      set
      {
        __isset.recipientUserId = true;
        this._recipientUserId = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="ShareRelationshipPrivilegeLevel"/>
    /// </summary>
    public ShareRelationshipPrivilegeLevel BestPrivilege
    {
      get
      {
        return _bestPrivilege;
      }
      set
      {
        __isset.bestPrivilege = true;
        this._bestPrivilege = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="ShareRelationshipPrivilegeLevel"/>
    /// </summary>
    public ShareRelationshipPrivilegeLevel IndividualPrivilege
    {
      get
      {
        return _individualPrivilege;
      }
      set
      {
        __isset.individualPrivilege = true;
        this._individualPrivilege = value;
      }
    }

    public ShareRelationshipRestrictions Restrictions
    {
      get
      {
        return _restrictions;
      }
      set
      {
        __isset.restrictions = true;
        this._restrictions = value;
      }
    }

    public int SharerUserId
    {
      get
      {
        return _sharerUserId;
      }
      set
      {
        __isset.sharerUserId = true;
        this._sharerUserId = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool displayName;
      public bool recipientUserId;
      public bool bestPrivilege;
      public bool individualPrivilege;
      public bool restrictions;
      public bool sharerUserId;
    }

    public MemberShareRelationship() {
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
                DisplayName = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                RecipientUserId = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                BestPrivilege = (ShareRelationshipPrivilegeLevel)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I32) {
                IndividualPrivilege = (ShareRelationshipPrivilegeLevel)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Struct) {
                Restrictions = new ShareRelationshipRestrictions();
                Restrictions.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I32) {
                SharerUserId = iprot.ReadI32();
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
        TStruct struc = new TStruct("MemberShareRelationship");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (DisplayName != null && __isset.displayName) {
          field.Name = "displayName";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(DisplayName);
          oprot.WriteFieldEnd();
        }
        if (__isset.recipientUserId) {
          field.Name = "recipientUserId";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(RecipientUserId);
          oprot.WriteFieldEnd();
        }
        if (__isset.bestPrivilege) {
          field.Name = "bestPrivilege";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)BestPrivilege);
          oprot.WriteFieldEnd();
        }
        if (__isset.individualPrivilege) {
          field.Name = "individualPrivilege";
          field.Type = TType.I32;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)IndividualPrivilege);
          oprot.WriteFieldEnd();
        }
        if (Restrictions != null && __isset.restrictions) {
          field.Name = "restrictions";
          field.Type = TType.Struct;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          Restrictions.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.sharerUserId) {
          field.Name = "sharerUserId";
          field.Type = TType.I32;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(SharerUserId);
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
      StringBuilder __sb = new StringBuilder("MemberShareRelationship(");
      bool __first = true;
      if (DisplayName != null && __isset.displayName) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DisplayName: ");
        __sb.Append(DisplayName);
      }
      if (__isset.recipientUserId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("RecipientUserId: ");
        __sb.Append(RecipientUserId);
      }
      if (__isset.bestPrivilege) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("BestPrivilege: ");
        __sb.Append(BestPrivilege);
      }
      if (__isset.individualPrivilege) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IndividualPrivilege: ");
        __sb.Append(IndividualPrivilege);
      }
      if (Restrictions != null && __isset.restrictions) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Restrictions: ");
        __sb.Append(Restrictions== null ? "<null>" : Restrictions.ToString());
      }
      if (__isset.sharerUserId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SharerUserId: ");
        __sb.Append(SharerUserId);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}