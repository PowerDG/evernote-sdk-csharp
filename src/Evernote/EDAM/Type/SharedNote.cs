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
  /// Represents a relationship between a note and a single share invitation recipient. The recipient
  /// is identified via an Identity, and has a given privilege that specifies what actions they may
  /// take on the note.
  /// 
  /// <dl>
  ///   <dt>sharerUserID</dt>
  ///   <dd>The user ID of the user who shared the note with the recipient.</dd>
  /// 
  ///   <dt>recipientIdentity</dt>
  ///   <dd>The identity of the recipient of the share. For a given note, there may be only one
  ///     SharedNote per recipient identity. Only recipientIdentity.id is guaranteed to be set.
  ///     Other fields on the Identity may or my not be set based on the requesting user's
  ///     relationship with the recipient.</dd>
  /// 
  ///   <dt>privilege</dt>
  ///   <dd>The privilege level that the share grants to the recipient.</dd>
  /// 
  ///   <dt>serviceCreated</dt>
  ///   <dd>The time at which the share was created.</dd>
  /// 
  ///   <dt>serviceUpdated</dt>
  ///   <dd>The time at which the share was last updated.</dd>
  /// 
  ///   <dt>serviceAssigned</dt>
  ///   <dd>The time at which the share was assigned to a specific recipient user ID.</dd>
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SharedNote : TBase
  {
    private int _sharerUserID;
    private Identity _recipientIdentity;
    private SharedNotePrivilegeLevel _privilege;
    private long _serviceCreated;
    private long _serviceUpdated;
    private long _serviceAssigned;

    public int SharerUserID
    {
      get
      {
        return _sharerUserID;
      }
      set
      {
        __isset.sharerUserID = true;
        this._sharerUserID = value;
      }
    }

    public Identity RecipientIdentity
    {
      get
      {
        return _recipientIdentity;
      }
      set
      {
        __isset.recipientIdentity = true;
        this._recipientIdentity = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="SharedNotePrivilegeLevel"/>
    /// </summary>
    public SharedNotePrivilegeLevel Privilege
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

    public long ServiceCreated
    {
      get
      {
        return _serviceCreated;
      }
      set
      {
        __isset.serviceCreated = true;
        this._serviceCreated = value;
      }
    }

    public long ServiceUpdated
    {
      get
      {
        return _serviceUpdated;
      }
      set
      {
        __isset.serviceUpdated = true;
        this._serviceUpdated = value;
      }
    }

    public long ServiceAssigned
    {
      get
      {
        return _serviceAssigned;
      }
      set
      {
        __isset.serviceAssigned = true;
        this._serviceAssigned = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool sharerUserID;
      public bool recipientIdentity;
      public bool privilege;
      public bool serviceCreated;
      public bool serviceUpdated;
      public bool serviceAssigned;
    }

    public SharedNote() {
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
                SharerUserID = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                RecipientIdentity = new Identity();
                RecipientIdentity.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                Privilege = (SharedNotePrivilegeLevel)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I64) {
                ServiceCreated = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.I64) {
                ServiceUpdated = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I64) {
                ServiceAssigned = iprot.ReadI64();
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
        TStruct struc = new TStruct("SharedNote");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.sharerUserID) {
          field.Name = "sharerUserID";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(SharerUserID);
          oprot.WriteFieldEnd();
        }
        if (RecipientIdentity != null && __isset.recipientIdentity) {
          field.Name = "recipientIdentity";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          RecipientIdentity.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.privilege) {
          field.Name = "privilege";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Privilege);
          oprot.WriteFieldEnd();
        }
        if (__isset.serviceCreated) {
          field.Name = "serviceCreated";
          field.Type = TType.I64;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(ServiceCreated);
          oprot.WriteFieldEnd();
        }
        if (__isset.serviceUpdated) {
          field.Name = "serviceUpdated";
          field.Type = TType.I64;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(ServiceUpdated);
          oprot.WriteFieldEnd();
        }
        if (__isset.serviceAssigned) {
          field.Name = "serviceAssigned";
          field.Type = TType.I64;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(ServiceAssigned);
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
      StringBuilder __sb = new StringBuilder("SharedNote(");
      bool __first = true;
      if (__isset.sharerUserID) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SharerUserID: ");
        __sb.Append(SharerUserID);
      }
      if (RecipientIdentity != null && __isset.recipientIdentity) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("RecipientIdentity: ");
        __sb.Append(RecipientIdentity== null ? "<null>" : RecipientIdentity.ToString());
      }
      if (__isset.privilege) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Privilege: ");
        __sb.Append(Privilege);
      }
      if (__isset.serviceCreated) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ServiceCreated: ");
        __sb.Append(ServiceCreated);
      }
      if (__isset.serviceUpdated) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ServiceUpdated: ");
        __sb.Append(ServiceUpdated);
      }
      if (__isset.serviceAssigned) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ServiceAssigned: ");
        __sb.Append(ServiceAssigned);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}