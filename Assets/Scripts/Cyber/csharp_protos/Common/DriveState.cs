// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/common/proto/drive_state.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Common {

  /// <summary>Holder for reflection information generated from modules/common/proto/drive_state.proto</summary>
  public static partial class DriveStateReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/common/proto/drive_state.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DriveStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZtb2R1bGVzL2NvbW1vbi9wcm90by9kcml2ZV9zdGF0ZS5wcm90bxINYXBv",
            "bGxvLmNvbW1vbiK8AQoMRW5nYWdlQWR2aWNlEjIKBmFkdmljZRgBIAEoDjIi",
            "LmFwb2xsby5jb21tb24uRW5nYWdlQWR2aWNlLkFkdmljZRIOCgZyZWFzb24Y",
            "AiABKAkiaAoGQWR2aWNlEgsKB1VOS05PV04QABITCg9ESVNBTExPV19FTkdB",
            "R0UQARITCg9SRUFEWV9UT19FTkdBR0UQAhIQCgxLRUVQX0VOR0FHRUQQAxIV",
            "ChFQUkVQQVJFX0RJU0VOR0FHRRAEYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Common.EngageAdvice), global::Apollo.Common.EngageAdvice.Parser, new[]{ "Advice", "Reason" }, null, new[]{ typeof(global::Apollo.Common.EngageAdvice.Types.Advice) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// This is the engage advice that published by critical runtime modules.
  /// </summary>
  public sealed partial class EngageAdvice : pb::IMessage<EngageAdvice> {
    private static readonly pb::MessageParser<EngageAdvice> _parser = new pb::MessageParser<EngageAdvice>(() => new EngageAdvice());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EngageAdvice> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Common.DriveStateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EngageAdvice() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EngageAdvice(EngageAdvice other) : this() {
      advice_ = other.advice_;
      reason_ = other.reason_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EngageAdvice Clone() {
      return new EngageAdvice(this);
    }

    /// <summary>Field number for the "advice" field.</summary>
    public const int AdviceFieldNumber = 1;
    private global::Apollo.Common.EngageAdvice.Types.Advice advice_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.EngageAdvice.Types.Advice Advice {
      get { return advice_; }
      set {
        advice_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 2;
    private string reason_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Reason {
      get { return reason_; }
      set {
        reason_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EngageAdvice);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EngageAdvice other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Advice != other.Advice) return false;
      if (Reason != other.Reason) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Advice != 0) hash ^= Advice.GetHashCode();
      if (Reason.Length != 0) hash ^= Reason.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Advice != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Advice);
      }
      if (Reason.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Reason);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Advice != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Advice);
      }
      if (Reason.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reason);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EngageAdvice other) {
      if (other == null) {
        return;
      }
      if (other.Advice != 0) {
        Advice = other.Advice;
      }
      if (other.Reason.Length != 0) {
        Reason = other.Reason;
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
          case 8: {
            advice_ = (global::Apollo.Common.EngageAdvice.Types.Advice) input.ReadEnum();
            break;
          }
          case 18: {
            Reason = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EngageAdvice message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Advice {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("DISALLOW_ENGAGE")] DisallowEngage = 1,
        [pbr::OriginalName("READY_TO_ENGAGE")] ReadyToEngage = 2,
        [pbr::OriginalName("KEEP_ENGAGED")] KeepEngaged = 3,
        [pbr::OriginalName("PREPARE_DISENGAGE")] PrepareDisengage = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
