// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/prediction/proto/scenario.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Prediction {

  /// <summary>Holder for reflection information generated from modules/prediction/proto/scenario.proto</summary>
  public static partial class ScenarioReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/prediction/proto/scenario.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScenarioReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidtb2R1bGVzL3ByZWRpY3Rpb24vcHJvdG8vc2NlbmFyaW8ucHJvdG8SEWFw",
            "b2xsby5wcmVkaWN0aW9uIt8BCghTY2VuYXJpbxIuCgR0eXBlGAEgASgOMiAu",
            "YXBvbGxvLnByZWRpY3Rpb24uU2NlbmFyaW8uVHlwZRITCgtqdW5jdGlvbl9p",
            "ZBgCIAEoCSKNAQoEVHlwZRILCgdVTktOT1dOEAASCwoGQ1JVSVNFEOgHEhEK",
            "DENSVUlTRV9VUkJBThDpBxITCg5DUlVJU0VfSElHSFdBWRDqBxINCghKVU5D",
            "VElPThDQDxIbChZKVU5DVElPTl9UUkFGRklDX0xJR0hUENEPEhcKEkpVTkNU",
            "SU9OX1NUT1BfU0lHThDSD2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Prediction.Scenario), global::Apollo.Prediction.Scenario.Parser, new[]{ "Type", "JunctionId" }, null, new[]{ typeof(global::Apollo.Prediction.Scenario.Types.Type) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Scenario : pb::IMessage<Scenario> {
    private static readonly pb::MessageParser<Scenario> _parser = new pb::MessageParser<Scenario>(() => new Scenario());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Scenario> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Prediction.ScenarioReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Scenario() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Scenario(Scenario other) : this() {
      type_ = other.type_;
      junctionId_ = other.junctionId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Scenario Clone() {
      return new Scenario(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Apollo.Prediction.Scenario.Types.Type type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Prediction.Scenario.Types.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "junction_id" field.</summary>
    public const int JunctionIdFieldNumber = 2;
    private string junctionId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JunctionId {
      get { return junctionId_; }
      set {
        junctionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Scenario);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Scenario other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (JunctionId != other.JunctionId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      if (JunctionId.Length != 0) hash ^= JunctionId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (JunctionId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(JunctionId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (JunctionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JunctionId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Scenario other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.JunctionId.Length != 0) {
        JunctionId = other.JunctionId;
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
            type_ = (global::Apollo.Prediction.Scenario.Types.Type) input.ReadEnum();
            break;
          }
          case 18: {
            JunctionId = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Scenario message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Type {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("CRUISE")] Cruise = 1000,
        [pbr::OriginalName("CRUISE_URBAN")] CruiseUrban = 1001,
        [pbr::OriginalName("CRUISE_HIGHWAY")] CruiseHighway = 1002,
        [pbr::OriginalName("JUNCTION")] Junction = 2000,
        [pbr::OriginalName("JUNCTION_TRAFFIC_LIGHT")] JunctionTrafficLight = 2001,
        [pbr::OriginalName("JUNCTION_STOP_SIGN")] JunctionStopSign = 2002,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
