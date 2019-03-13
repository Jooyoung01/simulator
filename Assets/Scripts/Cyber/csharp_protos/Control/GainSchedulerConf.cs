// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/control/proto/gain_scheduler_conf.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Control {

  /// <summary>Holder for reflection information generated from modules/control/proto/gain_scheduler_conf.proto</summary>
  public static partial class GainSchedulerConfReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/control/proto/gain_scheduler_conf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GainSchedulerConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9tb2R1bGVzL2NvbnRyb2wvcHJvdG8vZ2Fpbl9zY2hlZHVsZXJfY29uZi5w",
            "cm90bxIOYXBvbGxvLmNvbnRyb2wiRQoNR2FpblNjaGVkdWxlchI0CglzY2hl",
            "ZHVsZXIYASADKAsyIS5hcG9sbG8uY29udHJvbC5HYWluU2NoZWR1bGVySW5m",
            "byIxChFHYWluU2NoZWR1bGVySW5mbxINCgVzcGVlZBgBIAEoARINCgVyYXRp",
            "bxgCIAEoAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Control.GainScheduler), global::Apollo.Control.GainScheduler.Parser, new[]{ "Scheduler" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Control.GainSchedulerInfo), global::Apollo.Control.GainSchedulerInfo.Parser, new[]{ "Speed", "Ratio" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GainScheduler : pb::IMessage<GainScheduler> {
    private static readonly pb::MessageParser<GainScheduler> _parser = new pb::MessageParser<GainScheduler>(() => new GainScheduler());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GainScheduler> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Control.GainSchedulerConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GainScheduler() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GainScheduler(GainScheduler other) : this() {
      scheduler_ = other.scheduler_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GainScheduler Clone() {
      return new GainScheduler(this);
    }

    /// <summary>Field number for the "scheduler" field.</summary>
    public const int SchedulerFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Apollo.Control.GainSchedulerInfo> _repeated_scheduler_codec
        = pb::FieldCodec.ForMessage(10, global::Apollo.Control.GainSchedulerInfo.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Control.GainSchedulerInfo> scheduler_ = new pbc::RepeatedField<global::Apollo.Control.GainSchedulerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Control.GainSchedulerInfo> Scheduler {
      get { return scheduler_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GainScheduler);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GainScheduler other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!scheduler_.Equals(other.scheduler_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= scheduler_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      scheduler_.WriteTo(output, _repeated_scheduler_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += scheduler_.CalculateSize(_repeated_scheduler_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GainScheduler other) {
      if (other == null) {
        return;
      }
      scheduler_.Add(other.scheduler_);
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
            scheduler_.AddEntriesFrom(input, _repeated_scheduler_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GainSchedulerInfo : pb::IMessage<GainSchedulerInfo> {
    private static readonly pb::MessageParser<GainSchedulerInfo> _parser = new pb::MessageParser<GainSchedulerInfo>(() => new GainSchedulerInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GainSchedulerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Control.GainSchedulerConfReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GainSchedulerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GainSchedulerInfo(GainSchedulerInfo other) : this() {
      speed_ = other.speed_;
      ratio_ = other.ratio_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GainSchedulerInfo Clone() {
      return new GainSchedulerInfo(this);
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 1;
    private double speed_;
    /// <summary>
    /// m/s
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "ratio" field.</summary>
    public const int RatioFieldNumber = 2;
    private double ratio_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Ratio {
      get { return ratio_; }
      set {
        ratio_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GainSchedulerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GainSchedulerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Speed != other.Speed) return false;
      if (Ratio != other.Ratio) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Speed != 0D) hash ^= Speed.GetHashCode();
      if (Ratio != 0D) hash ^= Ratio.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Speed != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Speed);
      }
      if (Ratio != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Ratio);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Speed != 0D) {
        size += 1 + 8;
      }
      if (Ratio != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GainSchedulerInfo other) {
      if (other == null) {
        return;
      }
      if (other.Speed != 0D) {
        Speed = other.Speed;
      }
      if (other.Ratio != 0D) {
        Ratio = other.Ratio;
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
          case 9: {
            Speed = input.ReadDouble();
            break;
          }
          case 17: {
            Ratio = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
