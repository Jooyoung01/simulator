// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/drivers/proto/radar.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Drivers {

  /// <summary>Holder for reflection information generated from modules/drivers/proto/radar.proto</summary>
  public static partial class RadarReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/drivers/proto/radar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RadarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFtb2R1bGVzL2RyaXZlcnMvcHJvdG8vcmFkYXIucHJvdG8SDmFwb2xsby5k",
            "cml2ZXJzGiVtb2R1bGVzL2NvbW1vbi9wcm90by9lcnJvcl9jb2RlLnByb3Rv",
            "GiFtb2R1bGVzL2NvbW1vbi9wcm90by9oZWFkZXIucHJvdG8aI21vZHVsZXMv",
            "Y29tbW9uL3Byb3RvL2dlb21ldHJ5LnByb3RvIswFCg1SYWRhck9ic3RhY2xl",
            "EgoKAmlkGAEgASgFEjEKEXJlbGF0aXZlX3Bvc2l0aW9uGAIgASgLMhYuYXBv",
            "bGxvLmNvbW1vbi5Qb2ludDJEEjEKEXJlbGF0aXZlX3ZlbG9jaXR5GAMgASgL",
            "MhYuYXBvbGxvLmNvbW1vbi5Qb2ludDJEEgsKA3JjcxgEIAEoARJBCg1tb3Zp",
            "bmdfc3RhdHVzGAUgASgOMiouYXBvbGxvLmRyaXZlcnMuUmFkYXJPYnN0YWNs",
            "ZS5Nb3ZpbmdTdGF0dXMSDQoFd2lkdGgYBiABKAESDgoGbGVuZ3RoGAcgASgB",
            "Eg4KBmhlaWdodBgIIAEoARINCgV0aGV0YRgJIAEoARIxChFhYnNvbHV0ZV9w",
            "b3NpdGlvbhgKIAEoCzIWLmFwb2xsby5jb21tb24uUG9pbnQyRBIxChFhYnNv",
            "bHV0ZV92ZWxvY2l0eRgLIAEoCzIWLmFwb2xsby5jb21tb24uUG9pbnQyRBIN",
            "CgVjb3VudBgMIAEoBRIbChNtb3ZpbmdfZnJhbWVzX2NvdW50GA0gASgFEjQK",
            "BnN0YXR1cxgOIAEoDjIkLmFwb2xsby5kcml2ZXJzLlJhZGFyT2JzdGFjbGUu",
            "U3RhdHVzIq4BCgZTdGF0dXMSDQoJTk9fVEFSR0VUEAASDgoKTkVXX1RBUkdF",
            "VBABEhYKEk5FV19VUERBVEVEX1RBUkdFVBACEhIKDlVQREFURURfVEFSR0VU",
            "EAMSEgoOQ09BU1RFRF9UQVJHRVQQBBIRCg1NRVJHRURfVEFSR0VUEAUSGgoW",
            "SU5WQUxJRF9DT0FTVEVEX1RBUkdFVBAGEhYKEk5FV19DT0FTVEVEX1RBUkdF",
            "VBAHIkIKDE1vdmluZ1N0YXR1cxIOCgpTVEFUSU9OQVJZEAASCwoHTkVBUklO",
            "RxABEgsKB0FXQVlJTkcQAhIICgROT05FEAMihQIKDlJhZGFyT2JzdGFjbGVz",
            "EkkKDnJhZGFyX29ic3RhY2xlGAEgAygLMjEuYXBvbGxvLmRyaXZlcnMuUmFk",
            "YXJPYnN0YWNsZXMuUmFkYXJPYnN0YWNsZUVudHJ5EiUKBmhlYWRlchgCIAEo",
            "CzIVLmFwb2xsby5jb21tb24uSGVhZGVyEiwKCmVycm9yX2NvZGUYAyABKA4y",
            "GC5hcG9sbG8uY29tbW9uLkVycm9yQ29kZRpTChJSYWRhck9ic3RhY2xlRW50",
            "cnkSCwoDa2V5GAEgASgFEiwKBXZhbHVlGAIgASgLMh0uYXBvbGxvLmRyaXZl",
            "cnMuUmFkYXJPYnN0YWNsZToCOAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Common.ErrorCodeReflection.Descriptor, global::Apollo.Common.HeaderReflection.Descriptor, global::Apollo.Common.GeometryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Drivers.RadarObstacle), global::Apollo.Drivers.RadarObstacle.Parser, new[]{ "Id", "RelativePosition", "RelativeVelocity", "Rcs", "MovingStatus", "Width", "Length", "Height", "Theta", "AbsolutePosition", "AbsoluteVelocity", "Count", "MovingFramesCount", "Status" }, null, new[]{ typeof(global::Apollo.Drivers.RadarObstacle.Types.Status), typeof(global::Apollo.Drivers.RadarObstacle.Types.MovingStatus) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Drivers.RadarObstacles), global::Apollo.Drivers.RadarObstacles.Parser, new[]{ "RadarObstacle", "Header", "ErrorCode" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RadarObstacle : pb::IMessage<RadarObstacle> {
    private static readonly pb::MessageParser<RadarObstacle> _parser = new pb::MessageParser<RadarObstacle>(() => new RadarObstacle());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RadarObstacle> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Drivers.RadarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RadarObstacle() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RadarObstacle(RadarObstacle other) : this() {
      id_ = other.id_;
      RelativePosition = other.relativePosition_ != null ? other.RelativePosition.Clone() : null;
      RelativeVelocity = other.relativeVelocity_ != null ? other.RelativeVelocity.Clone() : null;
      rcs_ = other.rcs_;
      movingStatus_ = other.movingStatus_;
      width_ = other.width_;
      length_ = other.length_;
      height_ = other.height_;
      theta_ = other.theta_;
      AbsolutePosition = other.absolutePosition_ != null ? other.AbsolutePosition.Clone() : null;
      AbsoluteVelocity = other.absoluteVelocity_ != null ? other.AbsoluteVelocity.Clone() : null;
      count_ = other.count_;
      movingFramesCount_ = other.movingFramesCount_;
      status_ = other.status_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RadarObstacle Clone() {
      return new RadarObstacle(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    /// <summary>
    /// obstacle ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "relative_position" field.</summary>
    public const int RelativePositionFieldNumber = 2;
    private global::Apollo.Common.Point2D relativePosition_;
    /// <summary>
    /// obstacle position in the sl coordinate system.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Point2D RelativePosition {
      get { return relativePosition_; }
      set {
        relativePosition_ = value;
      }
    }

    /// <summary>Field number for the "relative_velocity" field.</summary>
    public const int RelativeVelocityFieldNumber = 3;
    private global::Apollo.Common.Point2D relativeVelocity_;
    /// <summary>
    /// obstacle relative velocity.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Point2D RelativeVelocity {
      get { return relativeVelocity_; }
      set {
        relativeVelocity_ = value;
      }
    }

    /// <summary>Field number for the "rcs" field.</summary>
    public const int RcsFieldNumber = 4;
    private double rcs_;
    /// <summary>
    /// radar signal intensity.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Rcs {
      get { return rcs_; }
      set {
        rcs_ = value;
      }
    }

    /// <summary>Field number for the "moving_status" field.</summary>
    public const int MovingStatusFieldNumber = 5;
    private global::Apollo.Drivers.RadarObstacle.Types.MovingStatus movingStatus_ = 0;
    /// <summary>
    /// whether this obstacle is able to move.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Drivers.RadarObstacle.Types.MovingStatus MovingStatus {
      get { return movingStatus_; }
      set {
        movingStatus_ = value;
      }
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 6;
    private double width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    /// <summary>Field number for the "length" field.</summary>
    public const int LengthFieldNumber = 7;
    private double length_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Length {
      get { return length_; }
      set {
        length_ = value;
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 8;
    private double height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "theta" field.</summary>
    public const int ThetaFieldNumber = 9;
    private double theta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Theta {
      get { return theta_; }
      set {
        theta_ = value;
      }
    }

    /// <summary>Field number for the "absolute_position" field.</summary>
    public const int AbsolutePositionFieldNumber = 10;
    private global::Apollo.Common.Point2D absolutePosition_;
    /// <summary>
    /// obstacle position in map coordinate system
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Point2D AbsolutePosition {
      get { return absolutePosition_; }
      set {
        absolutePosition_ = value;
      }
    }

    /// <summary>Field number for the "absolute_velocity" field.</summary>
    public const int AbsoluteVelocityFieldNumber = 11;
    private global::Apollo.Common.Point2D absoluteVelocity_;
    /// <summary>
    /// obstacle position in map coordinate system
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Point2D AbsoluteVelocity {
      get { return absoluteVelocity_; }
      set {
        absoluteVelocity_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 12;
    private int count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "moving_frames_count" field.</summary>
    public const int MovingFramesCountFieldNumber = 13;
    private int movingFramesCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MovingFramesCount {
      get { return movingFramesCount_; }
      set {
        movingFramesCount_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 14;
    private global::Apollo.Drivers.RadarObstacle.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Drivers.RadarObstacle.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RadarObstacle);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RadarObstacle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(RelativePosition, other.RelativePosition)) return false;
      if (!object.Equals(RelativeVelocity, other.RelativeVelocity)) return false;
      if (Rcs != other.Rcs) return false;
      if (MovingStatus != other.MovingStatus) return false;
      if (Width != other.Width) return false;
      if (Length != other.Length) return false;
      if (Height != other.Height) return false;
      if (Theta != other.Theta) return false;
      if (!object.Equals(AbsolutePosition, other.AbsolutePosition)) return false;
      if (!object.Equals(AbsoluteVelocity, other.AbsoluteVelocity)) return false;
      if (Count != other.Count) return false;
      if (MovingFramesCount != other.MovingFramesCount) return false;
      if (Status != other.Status) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (relativePosition_ != null) hash ^= RelativePosition.GetHashCode();
      if (relativeVelocity_ != null) hash ^= RelativeVelocity.GetHashCode();
      if (Rcs != 0D) hash ^= Rcs.GetHashCode();
      if (MovingStatus != 0) hash ^= MovingStatus.GetHashCode();
      if (Width != 0D) hash ^= Width.GetHashCode();
      if (Length != 0D) hash ^= Length.GetHashCode();
      if (Height != 0D) hash ^= Height.GetHashCode();
      if (Theta != 0D) hash ^= Theta.GetHashCode();
      if (absolutePosition_ != null) hash ^= AbsolutePosition.GetHashCode();
      if (absoluteVelocity_ != null) hash ^= AbsoluteVelocity.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      if (MovingFramesCount != 0) hash ^= MovingFramesCount.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (relativePosition_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RelativePosition);
      }
      if (relativeVelocity_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RelativeVelocity);
      }
      if (Rcs != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Rcs);
      }
      if (MovingStatus != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) MovingStatus);
      }
      if (Width != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Width);
      }
      if (Length != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Length);
      }
      if (Height != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(Height);
      }
      if (Theta != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(Theta);
      }
      if (absolutePosition_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(AbsolutePosition);
      }
      if (absoluteVelocity_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(AbsoluteVelocity);
      }
      if (Count != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Count);
      }
      if (MovingFramesCount != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(MovingFramesCount);
      }
      if (Status != 0) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Status);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (relativePosition_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RelativePosition);
      }
      if (relativeVelocity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RelativeVelocity);
      }
      if (Rcs != 0D) {
        size += 1 + 8;
      }
      if (MovingStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MovingStatus);
      }
      if (Width != 0D) {
        size += 1 + 8;
      }
      if (Length != 0D) {
        size += 1 + 8;
      }
      if (Height != 0D) {
        size += 1 + 8;
      }
      if (Theta != 0D) {
        size += 1 + 8;
      }
      if (absolutePosition_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbsolutePosition);
      }
      if (absoluteVelocity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbsoluteVelocity);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
      }
      if (MovingFramesCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MovingFramesCount);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RadarObstacle other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.relativePosition_ != null) {
        if (relativePosition_ == null) {
          relativePosition_ = new global::Apollo.Common.Point2D();
        }
        RelativePosition.MergeFrom(other.RelativePosition);
      }
      if (other.relativeVelocity_ != null) {
        if (relativeVelocity_ == null) {
          relativeVelocity_ = new global::Apollo.Common.Point2D();
        }
        RelativeVelocity.MergeFrom(other.RelativeVelocity);
      }
      if (other.Rcs != 0D) {
        Rcs = other.Rcs;
      }
      if (other.MovingStatus != 0) {
        MovingStatus = other.MovingStatus;
      }
      if (other.Width != 0D) {
        Width = other.Width;
      }
      if (other.Length != 0D) {
        Length = other.Length;
      }
      if (other.Height != 0D) {
        Height = other.Height;
      }
      if (other.Theta != 0D) {
        Theta = other.Theta;
      }
      if (other.absolutePosition_ != null) {
        if (absolutePosition_ == null) {
          absolutePosition_ = new global::Apollo.Common.Point2D();
        }
        AbsolutePosition.MergeFrom(other.AbsolutePosition);
      }
      if (other.absoluteVelocity_ != null) {
        if (absoluteVelocity_ == null) {
          absoluteVelocity_ = new global::Apollo.Common.Point2D();
        }
        AbsoluteVelocity.MergeFrom(other.AbsoluteVelocity);
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.MovingFramesCount != 0) {
        MovingFramesCount = other.MovingFramesCount;
      }
      if (other.Status != 0) {
        Status = other.Status;
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
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            if (relativePosition_ == null) {
              relativePosition_ = new global::Apollo.Common.Point2D();
            }
            input.ReadMessage(relativePosition_);
            break;
          }
          case 26: {
            if (relativeVelocity_ == null) {
              relativeVelocity_ = new global::Apollo.Common.Point2D();
            }
            input.ReadMessage(relativeVelocity_);
            break;
          }
          case 33: {
            Rcs = input.ReadDouble();
            break;
          }
          case 40: {
            movingStatus_ = (global::Apollo.Drivers.RadarObstacle.Types.MovingStatus) input.ReadEnum();
            break;
          }
          case 49: {
            Width = input.ReadDouble();
            break;
          }
          case 57: {
            Length = input.ReadDouble();
            break;
          }
          case 65: {
            Height = input.ReadDouble();
            break;
          }
          case 73: {
            Theta = input.ReadDouble();
            break;
          }
          case 82: {
            if (absolutePosition_ == null) {
              absolutePosition_ = new global::Apollo.Common.Point2D();
            }
            input.ReadMessage(absolutePosition_);
            break;
          }
          case 90: {
            if (absoluteVelocity_ == null) {
              absoluteVelocity_ = new global::Apollo.Common.Point2D();
            }
            input.ReadMessage(absoluteVelocity_);
            break;
          }
          case 96: {
            Count = input.ReadInt32();
            break;
          }
          case 104: {
            MovingFramesCount = input.ReadInt32();
            break;
          }
          case 112: {
            status_ = (global::Apollo.Drivers.RadarObstacle.Types.Status) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RadarObstacle message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("NO_TARGET")] NoTarget = 0,
        [pbr::OriginalName("NEW_TARGET")] NewTarget = 1,
        [pbr::OriginalName("NEW_UPDATED_TARGET")] NewUpdatedTarget = 2,
        [pbr::OriginalName("UPDATED_TARGET")] UpdatedTarget = 3,
        [pbr::OriginalName("COASTED_TARGET")] CoastedTarget = 4,
        [pbr::OriginalName("MERGED_TARGET")] MergedTarget = 5,
        [pbr::OriginalName("INVALID_COASTED_TARGET")] InvalidCoastedTarget = 6,
        [pbr::OriginalName("NEW_COASTED_TARGET")] NewCoastedTarget = 7,
      }

      public enum MovingStatus {
        [pbr::OriginalName("STATIONARY")] Stationary = 0,
        [pbr::OriginalName("NEARING")] Nearing = 1,
        [pbr::OriginalName("AWAYING")] Awaying = 2,
        [pbr::OriginalName("NONE")] None = 3,
      }

    }
    #endregion

  }

  public sealed partial class RadarObstacles : pb::IMessage<RadarObstacles> {
    private static readonly pb::MessageParser<RadarObstacles> _parser = new pb::MessageParser<RadarObstacles>(() => new RadarObstacles());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RadarObstacles> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Drivers.RadarReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RadarObstacles() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RadarObstacles(RadarObstacles other) : this() {
      radarObstacle_ = other.radarObstacle_.Clone();
      Header = other.header_ != null ? other.Header.Clone() : null;
      errorCode_ = other.errorCode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RadarObstacles Clone() {
      return new RadarObstacles(this);
    }

    /// <summary>Field number for the "radar_obstacle" field.</summary>
    public const int RadarObstacleFieldNumber = 1;
    private static readonly pbc::MapField<int, global::Apollo.Drivers.RadarObstacle>.Codec _map_radarObstacle_codec
        = new pbc::MapField<int, global::Apollo.Drivers.RadarObstacle>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForMessage(18, global::Apollo.Drivers.RadarObstacle.Parser), 10);
    private readonly pbc::MapField<int, global::Apollo.Drivers.RadarObstacle> radarObstacle_ = new pbc::MapField<int, global::Apollo.Drivers.RadarObstacle>();
    /// <summary>
    /// An array of obstacles
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::Apollo.Drivers.RadarObstacle> RadarObstacle {
      get { return radarObstacle_; }
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 2;
    private global::Apollo.Common.Header header_;
    /// <summary>
    /// Header
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "error_code" field.</summary>
    public const int ErrorCodeFieldNumber = 3;
    private global::Apollo.Common.ErrorCode errorCode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.ErrorCode ErrorCode {
      get { return errorCode_; }
      set {
        errorCode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RadarObstacles);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RadarObstacles other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!RadarObstacle.Equals(other.RadarObstacle)) return false;
      if (!object.Equals(Header, other.Header)) return false;
      if (ErrorCode != other.ErrorCode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= RadarObstacle.GetHashCode();
      if (header_ != null) hash ^= Header.GetHashCode();
      if (ErrorCode != 0) hash ^= ErrorCode.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      radarObstacle_.WriteTo(output, _map_radarObstacle_codec);
      if (header_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Header);
      }
      if (ErrorCode != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ErrorCode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += radarObstacle_.CalculateSize(_map_radarObstacle_codec);
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (ErrorCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ErrorCode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RadarObstacles other) {
      if (other == null) {
        return;
      }
      radarObstacle_.Add(other.radarObstacle_);
      if (other.header_ != null) {
        if (header_ == null) {
          header_ = new global::Apollo.Common.Header();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.ErrorCode != 0) {
        ErrorCode = other.ErrorCode;
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
            radarObstacle_.AddEntriesFrom(input, _map_radarObstacle_codec);
            break;
          }
          case 18: {
            if (header_ == null) {
              header_ = new global::Apollo.Common.Header();
            }
            input.ReadMessage(header_);
            break;
          }
          case 24: {
            errorCode_ = (global::Apollo.Common.ErrorCode) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
