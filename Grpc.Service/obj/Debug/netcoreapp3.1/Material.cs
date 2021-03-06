// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/material.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc.Service {

  /// <summary>Holder for reflection information generated from Protos/material.proto</summary>
  public static partial class MaterialReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/material.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MaterialReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvbWF0ZXJpYWwucHJvdG8SCG1hdGVyaWFsIkEKDU1hdGVyaWFs",
            "TW9kZWwSCgoCc24YASABKAkSEgoKa2V5cGFydF9ubxgCIAEoCRIQCghxdWFu",
            "dGl0eRgDIAEoBSI+Cg5NYXRlcmlhbFJldHVybhILCgNyZXQYASABKAgSDgoG",
            "c3RhdHVzGAIgASgFEg8KB21lc3NhZ2UYAyABKAkygQEKCG1hdGVyaWFsEjgK",
            "A0FkZBIXLm1hdGVyaWFsLk1hdGVyaWFsTW9kZWwaGC5tYXRlcmlhbC5NYXRl",
            "cmlhbFJldHVybhI7CgZSZWR1Y2USFy5tYXRlcmlhbC5NYXRlcmlhbE1vZGVs",
            "GhgubWF0ZXJpYWwuTWF0ZXJpYWxSZXR1cm5CD6oCDEdycGMuU2VydmljZWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Service.MaterialModel), global::Grpc.Service.MaterialModel.Parser, new[]{ "Sn", "KeypartNo", "Quantity" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Service.MaterialReturn), global::Grpc.Service.MaterialReturn.Parser, new[]{ "Ret", "Status", "Message" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 物料模型
  /// </summary>
  public sealed partial class MaterialModel : pb::IMessage<MaterialModel> {
    private static readonly pb::MessageParser<MaterialModel> _parser = new pb::MessageParser<MaterialModel>(() => new MaterialModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MaterialModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Service.MaterialReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaterialModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaterialModel(MaterialModel other) : this() {
      sn_ = other.sn_;
      keypartNo_ = other.keypartNo_;
      quantity_ = other.quantity_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaterialModel Clone() {
      return new MaterialModel(this);
    }

    /// <summary>Field number for the "sn" field.</summary>
    public const int SnFieldNumber = 1;
    private string sn_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Sn {
      get { return sn_; }
      set {
        sn_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "keypart_no" field.</summary>
    public const int KeypartNoFieldNumber = 2;
    private string keypartNo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KeypartNo {
      get { return keypartNo_; }
      set {
        keypartNo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 3;
    private int quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MaterialModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MaterialModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Sn != other.Sn) return false;
      if (KeypartNo != other.KeypartNo) return false;
      if (Quantity != other.Quantity) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Sn.Length != 0) hash ^= Sn.GetHashCode();
      if (KeypartNo.Length != 0) hash ^= KeypartNo.GetHashCode();
      if (Quantity != 0) hash ^= Quantity.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Sn.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Sn);
      }
      if (KeypartNo.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(KeypartNo);
      }
      if (Quantity != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Quantity);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Sn.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sn);
      }
      if (KeypartNo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KeypartNo);
      }
      if (Quantity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantity);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MaterialModel other) {
      if (other == null) {
        return;
      }
      if (other.Sn.Length != 0) {
        Sn = other.Sn;
      }
      if (other.KeypartNo.Length != 0) {
        KeypartNo = other.KeypartNo;
      }
      if (other.Quantity != 0) {
        Quantity = other.Quantity;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Sn = input.ReadString();
            break;
          }
          case 18: {
            KeypartNo = input.ReadString();
            break;
          }
          case 24: {
            Quantity = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 物料处理消息回复模型
  /// </summary>
  public sealed partial class MaterialReturn : pb::IMessage<MaterialReturn> {
    private static readonly pb::MessageParser<MaterialReturn> _parser = new pb::MessageParser<MaterialReturn>(() => new MaterialReturn());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MaterialReturn> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Service.MaterialReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaterialReturn() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaterialReturn(MaterialReturn other) : this() {
      ret_ = other.ret_;
      status_ = other.status_;
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaterialReturn Clone() {
      return new MaterialReturn(this);
    }

    /// <summary>Field number for the "ret" field.</summary>
    public const int RetFieldNumber = 1;
    private bool ret_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Ret {
      get { return ret_; }
      set {
        ret_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private int status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 3;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MaterialReturn);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MaterialReturn other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ret != other.Ret) return false;
      if (Status != other.Status) return false;
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ret != false) hash ^= Ret.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ret != false) {
        output.WriteRawTag(8);
        output.WriteBool(Ret);
      }
      if (Status != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Status);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ret != false) {
        size += 1 + 1;
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Status);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MaterialReturn other) {
      if (other == null) {
        return;
      }
      if (other.Ret != false) {
        Ret = other.Ret;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Ret = input.ReadBool();
            break;
          }
          case 16: {
            Status = input.ReadInt32();
            break;
          }
          case 26: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
