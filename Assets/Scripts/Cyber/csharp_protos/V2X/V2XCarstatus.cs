// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/v2x/proto/v2x_carstatus.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.V2X {

  /// <summary>Holder for reflection information generated from modules/v2x/proto/v2x_carstatus.proto</summary>
  public static partial class V2XCarstatusReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/v2x/proto/v2x_carstatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static V2XCarstatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVtb2R1bGVzL3YyeC9wcm90by92MnhfY2Fyc3RhdHVzLnByb3RvEgphcG9s",
            "bG8udjJ4Gi1tb2R1bGVzL2xvY2FsaXphdGlvbi9wcm90by9sb2NhbGl6YXRp",
            "b24ucHJvdG8aKW1vZHVsZXMvY2FuYnVzL3Byb3RvL2NoYXNzaXNfZGV0YWls",
            "LnByb3RvIoIBCglDYXJTdGF0dXMSPwoMbG9jYWxpemF0aW9uGAEgASgLMiku",
            "YXBvbGxvLmxvY2FsaXphdGlvbi5Mb2NhbGl6YXRpb25Fc3RpbWF0ZRI0Cg5j",
            "aGFzc2lzX2RldGFpbBgCIAEoCzIcLmFwb2xsby5jYW5idXMuQ2hhc3Npc0Rl",
            "dGFpbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Localization.LocalizationReflection.Descriptor, global::Apollo.Canbus.ChassisDetailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.V2X.CarStatus), global::Apollo.V2X.CarStatus.Parser, new[]{ "Localization", "ChassisDetail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CarStatus : pb::IMessage<CarStatus> {
    private static readonly pb::MessageParser<CarStatus> _parser = new pb::MessageParser<CarStatus>(() => new CarStatus());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CarStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.V2X.V2XCarstatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarStatus(CarStatus other) : this() {
      Localization = other.localization_ != null ? other.Localization.Clone() : null;
      ChassisDetail = other.chassisDetail_ != null ? other.ChassisDetail.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarStatus Clone() {
      return new CarStatus(this);
    }

    /// <summary>Field number for the "localization" field.</summary>
    public const int LocalizationFieldNumber = 1;
    private global::Apollo.Localization.LocalizationEstimate localization_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Localization.LocalizationEstimate Localization {
      get { return localization_; }
      set {
        localization_ = value;
      }
    }

    /// <summary>Field number for the "chassis_detail" field.</summary>
    public const int ChassisDetailFieldNumber = 2;
    private global::Apollo.Canbus.ChassisDetail chassisDetail_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Canbus.ChassisDetail ChassisDetail {
      get { return chassisDetail_; }
      set {
        chassisDetail_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CarStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CarStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Localization, other.Localization)) return false;
      if (!object.Equals(ChassisDetail, other.ChassisDetail)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (localization_ != null) hash ^= Localization.GetHashCode();
      if (chassisDetail_ != null) hash ^= ChassisDetail.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (localization_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Localization);
      }
      if (chassisDetail_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ChassisDetail);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (localization_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Localization);
      }
      if (chassisDetail_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChassisDetail);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CarStatus other) {
      if (other == null) {
        return;
      }
      if (other.localization_ != null) {
        if (localization_ == null) {
          localization_ = new global::Apollo.Localization.LocalizationEstimate();
        }
        Localization.MergeFrom(other.Localization);
      }
      if (other.chassisDetail_ != null) {
        if (chassisDetail_ == null) {
          chassisDetail_ = new global::Apollo.Canbus.ChassisDetail();
        }
        ChassisDetail.MergeFrom(other.ChassisDetail);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (localization_ == null) {
              localization_ = new global::Apollo.Localization.LocalizationEstimate();
            }
            input.ReadMessage(localization_);
            break;
          }
          case 18: {
            if (chassisDetail_ == null) {
              chassisDetail_ = new global::Apollo.Canbus.ChassisDetail();
            }
            input.ReadMessage(chassisDetail_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
