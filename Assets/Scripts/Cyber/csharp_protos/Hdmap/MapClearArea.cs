// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/map/proto/map_clear_area.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Hdmap {

  /// <summary>Holder for reflection information generated from modules/map/proto/map_clear_area.proto</summary>
  public static partial class MapClearAreaReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/map/proto/map_clear_area.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapClearAreaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZtb2R1bGVzL21hcC9wcm90by9tYXBfY2xlYXJfYXJlYS5wcm90bxIMYXBv",
            "bGxvLmhkbWFwGh5tb2R1bGVzL21hcC9wcm90by9tYXBfaWQucHJvdG8aJG1v",
            "ZHVsZXMvbWFwL3Byb3RvL21hcF9nZW9tZXRyeS5wcm90byJ3CglDbGVhckFy",
            "ZWESHAoCaWQYASABKAsyEC5hcG9sbG8uaGRtYXAuSWQSJAoKb3ZlcmxhcF9p",
            "ZBgCIAMoCzIQLmFwb2xsby5oZG1hcC5JZBImCgdwb2x5Z29uGAMgASgLMhUu",
            "YXBvbGxvLmhkbWFwLlBvbHlnb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Hdmap.MapIdReflection.Descriptor, global::Apollo.Hdmap.MapGeometryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.ClearArea), global::Apollo.Hdmap.ClearArea.Parser, new[]{ "Id", "OverlapId", "Polygon" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClearArea : pb::IMessage<ClearArea> {
    private static readonly pb::MessageParser<ClearArea> _parser = new pb::MessageParser<ClearArea>(() => new ClearArea());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClearArea> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapClearAreaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClearArea() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClearArea(ClearArea other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
      overlapId_ = other.overlapId_.Clone();
      Polygon = other.polygon_ != null ? other.Polygon.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClearArea Clone() {
      return new ClearArea(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::Apollo.Hdmap.Id id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Id Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "overlap_id" field.</summary>
    public const int OverlapIdFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Id> _repeated_overlapId_codec
        = pb::FieldCodec.ForMessage(18, global::Apollo.Hdmap.Id.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Id> overlapId_ = new pbc::RepeatedField<global::Apollo.Hdmap.Id>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Id> OverlapId {
      get { return overlapId_; }
    }

    /// <summary>Field number for the "polygon" field.</summary>
    public const int PolygonFieldNumber = 3;
    private global::Apollo.Hdmap.Polygon polygon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Polygon Polygon {
      get { return polygon_; }
      set {
        polygon_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClearArea);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClearArea other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if(!overlapId_.Equals(other.overlapId_)) return false;
      if (!object.Equals(Polygon, other.Polygon)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      hash ^= overlapId_.GetHashCode();
      if (polygon_ != null) hash ^= Polygon.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
      overlapId_.WriteTo(output, _repeated_overlapId_codec);
      if (polygon_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Polygon);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      size += overlapId_.CalculateSize(_repeated_overlapId_codec);
      if (polygon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Polygon);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClearArea other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::Apollo.Hdmap.Id();
        }
        Id.MergeFrom(other.Id);
      }
      overlapId_.Add(other.overlapId_);
      if (other.polygon_ != null) {
        if (polygon_ == null) {
          polygon_ = new global::Apollo.Hdmap.Polygon();
        }
        Polygon.MergeFrom(other.Polygon);
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
            if (id_ == null) {
              id_ = new global::Apollo.Hdmap.Id();
            }
            input.ReadMessage(id_);
            break;
          }
          case 18: {
            overlapId_.AddEntriesFrom(input, _repeated_overlapId_codec);
            break;
          }
          case 26: {
            if (polygon_ == null) {
              polygon_ = new global::Apollo.Hdmap.Polygon();
            }
            input.ReadMessage(polygon_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
