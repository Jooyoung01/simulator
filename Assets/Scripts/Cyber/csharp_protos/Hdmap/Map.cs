// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/map/proto/map.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Hdmap {

  /// <summary>Holder for reflection information generated from modules/map/proto/map.proto</summary>
  public static partial class MapReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/map/proto/map.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chttb2R1bGVzL21hcC9wcm90by9tYXAucHJvdG8SDGFwb2xsby5oZG1hcBom",
            "bW9kdWxlcy9tYXAvcHJvdG8vbWFwX2NsZWFyX2FyZWEucHJvdG8aJW1vZHVs",
            "ZXMvbWFwL3Byb3RvL21hcF9jcm9zc3dhbGsucHJvdG8aJG1vZHVsZXMvbWFw",
            "L3Byb3RvL21hcF9qdW5jdGlvbi5wcm90bxogbW9kdWxlcy9tYXAvcHJvdG8v",
            "bWFwX2xhbmUucHJvdG8aI21vZHVsZXMvbWFwL3Byb3RvL21hcF9vdmVybGFw",
            "LnByb3RvGiJtb2R1bGVzL21hcC9wcm90by9tYXBfc2lnbmFsLnByb3RvGiZt",
            "b2R1bGVzL21hcC9wcm90by9tYXBfc3BlZWRfYnVtcC5wcm90bxolbW9kdWxl",
            "cy9tYXAvcHJvdG8vbWFwX3N0b3Bfc2lnbi5wcm90bxombW9kdWxlcy9tYXAv",
            "cHJvdG8vbWFwX3lpZWxkX3NpZ24ucHJvdG8aIG1vZHVsZXMvbWFwL3Byb3Rv",
            "L21hcF9yb2FkLnByb3RvGiltb2R1bGVzL21hcC9wcm90by9tYXBfcGFya2lu",
            "Z19zcGFjZS5wcm90bxoobW9kdWxlcy9tYXAvcHJvdG8vbWFwX3BuY19qdW5j",
            "dGlvbi5wcm90byIaCgpQcm9qZWN0aW9uEgwKBHByb2oYASABKAki6wEKBkhl",
            "YWRlchIPCgd2ZXJzaW9uGAEgASgMEgwKBGRhdGUYAiABKAwSLAoKcHJvamVj",
            "dGlvbhgDIAEoCzIYLmFwb2xsby5oZG1hcC5Qcm9qZWN0aW9uEhAKCGRpc3Ry",
            "aWN0GAQgASgMEhIKCmdlbmVyYXRpb24YBSABKAwSEQoJcmV2X21ham9yGAYg",
            "ASgMEhEKCXJldl9taW5vchgHIAEoDBIMCgRsZWZ0GAggASgBEgsKA3RvcBgJ",
            "IAEoARINCgVyaWdodBgKIAEoARIOCgZib3R0b20YCyABKAESDgoGdmVuZG9y",
            "GAwgASgMIqQECgNNYXASJAoGaGVhZGVyGAEgASgLMhQuYXBvbGxvLmhkbWFw",
            "LkhlYWRlchIqCgljcm9zc3dhbGsYAiADKAsyFy5hcG9sbG8uaGRtYXAuQ3Jv",
            "c3N3YWxrEigKCGp1bmN0aW9uGAMgAygLMhYuYXBvbGxvLmhkbWFwLkp1bmN0",
            "aW9uEiAKBGxhbmUYBCADKAsyEi5hcG9sbG8uaGRtYXAuTGFuZRIpCglzdG9w",
            "X3NpZ24YBSADKAsyFi5hcG9sbG8uaGRtYXAuU3RvcFNpZ24SJAoGc2lnbmFs",
            "GAYgAygLMhQuYXBvbGxvLmhkbWFwLlNpZ25hbBImCgV5aWVsZBgHIAMoCzIX",
            "LmFwb2xsby5oZG1hcC5ZaWVsZFNpZ24SJgoHb3ZlcmxhcBgIIAMoCzIVLmFw",
            "b2xsby5oZG1hcC5PdmVybGFwEisKCmNsZWFyX2FyZWEYCSADKAsyFy5hcG9s",
            "bG8uaGRtYXAuQ2xlYXJBcmVhEisKCnNwZWVkX2J1bXAYCiADKAsyFy5hcG9s",
            "bG8uaGRtYXAuU3BlZWRCdW1wEiAKBHJvYWQYCyADKAsyEi5hcG9sbG8uaGRt",
            "YXAuUm9hZBIxCg1wYXJraW5nX3NwYWNlGAwgAygLMhouYXBvbGxvLmhkbWFw",
            "LlBhcmtpbmdTcGFjZRIvCgxwbmNfanVuY3Rpb24YDSADKAsyGS5hcG9sbG8u",
            "aGRtYXAuUE5DSnVuY3Rpb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Hdmap.MapClearAreaReflection.Descriptor, global::Apollo.Hdmap.MapCrosswalkReflection.Descriptor, global::Apollo.Hdmap.MapJunctionReflection.Descriptor, global::Apollo.Hdmap.MapLaneReflection.Descriptor, global::Apollo.Hdmap.MapOverlapReflection.Descriptor, global::Apollo.Hdmap.MapSignalReflection.Descriptor, global::Apollo.Hdmap.MapSpeedBumpReflection.Descriptor, global::Apollo.Hdmap.MapStopSignReflection.Descriptor, global::Apollo.Hdmap.MapYieldSignReflection.Descriptor, global::Apollo.Hdmap.MapRoadReflection.Descriptor, global::Apollo.Hdmap.MapParkingSpaceReflection.Descriptor, global::Apollo.Hdmap.MapPncJunctionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.Projection), global::Apollo.Hdmap.Projection.Parser, new[]{ "Proj" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.Header), global::Apollo.Hdmap.Header.Parser, new[]{ "Version", "Date", "Projection", "District", "Generation", "RevMajor", "RevMinor", "Left", "Top", "Right", "Bottom", "Vendor" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.Map), global::Apollo.Hdmap.Map.Parser, new[]{ "Header", "Crosswalk", "Junction", "Lane", "StopSign", "Signal", "Yield", "Overlap", "ClearArea", "SpeedBump", "Road", "ParkingSpace", "PncJunction" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// This message defines how we project the ellipsoidal Earth surface to a plane.
  /// </summary>
  public sealed partial class Projection : pb::IMessage<Projection> {
    private static readonly pb::MessageParser<Projection> _parser = new pb::MessageParser<Projection>(() => new Projection());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Projection> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Projection() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Projection(Projection other) : this() {
      proj_ = other.proj_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Projection Clone() {
      return new Projection(this);
    }

    /// <summary>Field number for the "proj" field.</summary>
    public const int ProjFieldNumber = 1;
    private string proj_ = "";
    /// <summary>
    /// PROJ.4 setting:
    /// "+proj=tmerc +lat_0={origin.lat} +lon_0={origin.lon} +k={scale_factor}
    /// +ellps=WGS84 +no_defs"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Proj {
      get { return proj_; }
      set {
        proj_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Projection);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Projection other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Proj != other.Proj) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Proj.Length != 0) hash ^= Proj.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Proj.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Proj);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Proj.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Proj);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Projection other) {
      if (other == null) {
        return;
      }
      if (other.Proj.Length != 0) {
        Proj = other.Proj;
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
            Proj = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Header : pb::IMessage<Header> {
    private static readonly pb::MessageParser<Header> _parser = new pb::MessageParser<Header>(() => new Header());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Header> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Header() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Header(Header other) : this() {
      version_ = other.version_;
      date_ = other.date_;
      Projection = other.projection_ != null ? other.Projection.Clone() : null;
      district_ = other.district_;
      generation_ = other.generation_;
      revMajor_ = other.revMajor_;
      revMinor_ = other.revMinor_;
      left_ = other.left_;
      top_ = other.top_;
      right_ = other.right_;
      bottom_ = other.bottom_;
      vendor_ = other.vendor_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Header Clone() {
      return new Header(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private pb::ByteString version_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 2;
    private pb::ByteString date_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Date {
      get { return date_; }
      set {
        date_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "projection" field.</summary>
    public const int ProjectionFieldNumber = 3;
    private global::Apollo.Hdmap.Projection projection_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Projection Projection {
      get { return projection_; }
      set {
        projection_ = value;
      }
    }

    /// <summary>Field number for the "district" field.</summary>
    public const int DistrictFieldNumber = 4;
    private pb::ByteString district_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString District {
      get { return district_; }
      set {
        district_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "generation" field.</summary>
    public const int GenerationFieldNumber = 5;
    private pb::ByteString generation_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Generation {
      get { return generation_; }
      set {
        generation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rev_major" field.</summary>
    public const int RevMajorFieldNumber = 6;
    private pb::ByteString revMajor_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString RevMajor {
      get { return revMajor_; }
      set {
        revMajor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rev_minor" field.</summary>
    public const int RevMinorFieldNumber = 7;
    private pb::ByteString revMinor_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString RevMinor {
      get { return revMinor_; }
      set {
        revMinor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "left" field.</summary>
    public const int LeftFieldNumber = 8;
    private double left_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Left {
      get { return left_; }
      set {
        left_ = value;
      }
    }

    /// <summary>Field number for the "top" field.</summary>
    public const int TopFieldNumber = 9;
    private double top_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Top {
      get { return top_; }
      set {
        top_ = value;
      }
    }

    /// <summary>Field number for the "right" field.</summary>
    public const int RightFieldNumber = 10;
    private double right_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Right {
      get { return right_; }
      set {
        right_ = value;
      }
    }

    /// <summary>Field number for the "bottom" field.</summary>
    public const int BottomFieldNumber = 11;
    private double bottom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Bottom {
      get { return bottom_; }
      set {
        bottom_ = value;
      }
    }

    /// <summary>Field number for the "vendor" field.</summary>
    public const int VendorFieldNumber = 12;
    private pb::ByteString vendor_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Vendor {
      get { return vendor_; }
      set {
        vendor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Header);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Header other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (Date != other.Date) return false;
      if (!object.Equals(Projection, other.Projection)) return false;
      if (District != other.District) return false;
      if (Generation != other.Generation) return false;
      if (RevMajor != other.RevMajor) return false;
      if (RevMinor != other.RevMinor) return false;
      if (Left != other.Left) return false;
      if (Top != other.Top) return false;
      if (Right != other.Right) return false;
      if (Bottom != other.Bottom) return false;
      if (Vendor != other.Vendor) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (Date.Length != 0) hash ^= Date.GetHashCode();
      if (projection_ != null) hash ^= Projection.GetHashCode();
      if (District.Length != 0) hash ^= District.GetHashCode();
      if (Generation.Length != 0) hash ^= Generation.GetHashCode();
      if (RevMajor.Length != 0) hash ^= RevMajor.GetHashCode();
      if (RevMinor.Length != 0) hash ^= RevMinor.GetHashCode();
      if (Left != 0D) hash ^= Left.GetHashCode();
      if (Top != 0D) hash ^= Top.GetHashCode();
      if (Right != 0D) hash ^= Right.GetHashCode();
      if (Bottom != 0D) hash ^= Bottom.GetHashCode();
      if (Vendor.Length != 0) hash ^= Vendor.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Version.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Version);
      }
      if (Date.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Date);
      }
      if (projection_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Projection);
      }
      if (District.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(District);
      }
      if (Generation.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Generation);
      }
      if (RevMajor.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(RevMajor);
      }
      if (RevMinor.Length != 0) {
        output.WriteRawTag(58);
        output.WriteBytes(RevMinor);
      }
      if (Left != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(Left);
      }
      if (Top != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(Top);
      }
      if (Right != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(Right);
      }
      if (Bottom != 0D) {
        output.WriteRawTag(89);
        output.WriteDouble(Bottom);
      }
      if (Vendor.Length != 0) {
        output.WriteRawTag(98);
        output.WriteBytes(Vendor);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Version);
      }
      if (Date.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Date);
      }
      if (projection_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Projection);
      }
      if (District.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(District);
      }
      if (Generation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Generation);
      }
      if (RevMajor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(RevMajor);
      }
      if (RevMinor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(RevMinor);
      }
      if (Left != 0D) {
        size += 1 + 8;
      }
      if (Top != 0D) {
        size += 1 + 8;
      }
      if (Right != 0D) {
        size += 1 + 8;
      }
      if (Bottom != 0D) {
        size += 1 + 8;
      }
      if (Vendor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Vendor);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Header other) {
      if (other == null) {
        return;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      if (other.Date.Length != 0) {
        Date = other.Date;
      }
      if (other.projection_ != null) {
        if (projection_ == null) {
          projection_ = new global::Apollo.Hdmap.Projection();
        }
        Projection.MergeFrom(other.Projection);
      }
      if (other.District.Length != 0) {
        District = other.District;
      }
      if (other.Generation.Length != 0) {
        Generation = other.Generation;
      }
      if (other.RevMajor.Length != 0) {
        RevMajor = other.RevMajor;
      }
      if (other.RevMinor.Length != 0) {
        RevMinor = other.RevMinor;
      }
      if (other.Left != 0D) {
        Left = other.Left;
      }
      if (other.Top != 0D) {
        Top = other.Top;
      }
      if (other.Right != 0D) {
        Right = other.Right;
      }
      if (other.Bottom != 0D) {
        Bottom = other.Bottom;
      }
      if (other.Vendor.Length != 0) {
        Vendor = other.Vendor;
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
            Version = input.ReadBytes();
            break;
          }
          case 18: {
            Date = input.ReadBytes();
            break;
          }
          case 26: {
            if (projection_ == null) {
              projection_ = new global::Apollo.Hdmap.Projection();
            }
            input.ReadMessage(projection_);
            break;
          }
          case 34: {
            District = input.ReadBytes();
            break;
          }
          case 42: {
            Generation = input.ReadBytes();
            break;
          }
          case 50: {
            RevMajor = input.ReadBytes();
            break;
          }
          case 58: {
            RevMinor = input.ReadBytes();
            break;
          }
          case 65: {
            Left = input.ReadDouble();
            break;
          }
          case 73: {
            Top = input.ReadDouble();
            break;
          }
          case 81: {
            Right = input.ReadDouble();
            break;
          }
          case 89: {
            Bottom = input.ReadDouble();
            break;
          }
          case 98: {
            Vendor = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Map : pb::IMessage<Map> {
    private static readonly pb::MessageParser<Map> _parser = new pb::MessageParser<Map>(() => new Map());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Map> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Map() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Map(Map other) : this() {
      Header = other.header_ != null ? other.Header.Clone() : null;
      crosswalk_ = other.crosswalk_.Clone();
      junction_ = other.junction_.Clone();
      lane_ = other.lane_.Clone();
      stopSign_ = other.stopSign_.Clone();
      signal_ = other.signal_.Clone();
      yield_ = other.yield_.Clone();
      overlap_ = other.overlap_.Clone();
      clearArea_ = other.clearArea_.Clone();
      speedBump_ = other.speedBump_.Clone();
      road_ = other.road_.Clone();
      parkingSpace_ = other.parkingSpace_.Clone();
      pncJunction_ = other.pncJunction_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Map Clone() {
      return new Map(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Apollo.Hdmap.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "crosswalk" field.</summary>
    public const int CrosswalkFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Crosswalk> _repeated_crosswalk_codec
        = pb::FieldCodec.ForMessage(18, global::Apollo.Hdmap.Crosswalk.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Crosswalk> crosswalk_ = new pbc::RepeatedField<global::Apollo.Hdmap.Crosswalk>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Crosswalk> Crosswalk {
      get { return crosswalk_; }
    }

    /// <summary>Field number for the "junction" field.</summary>
    public const int JunctionFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Junction> _repeated_junction_codec
        = pb::FieldCodec.ForMessage(26, global::Apollo.Hdmap.Junction.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Junction> junction_ = new pbc::RepeatedField<global::Apollo.Hdmap.Junction>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Junction> Junction {
      get { return junction_; }
    }

    /// <summary>Field number for the "lane" field.</summary>
    public const int LaneFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Lane> _repeated_lane_codec
        = pb::FieldCodec.ForMessage(34, global::Apollo.Hdmap.Lane.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Lane> lane_ = new pbc::RepeatedField<global::Apollo.Hdmap.Lane>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Lane> Lane {
      get { return lane_; }
    }

    /// <summary>Field number for the "stop_sign" field.</summary>
    public const int StopSignFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.StopSign> _repeated_stopSign_codec
        = pb::FieldCodec.ForMessage(42, global::Apollo.Hdmap.StopSign.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.StopSign> stopSign_ = new pbc::RepeatedField<global::Apollo.Hdmap.StopSign>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.StopSign> StopSign {
      get { return stopSign_; }
    }

    /// <summary>Field number for the "signal" field.</summary>
    public const int SignalFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Signal> _repeated_signal_codec
        = pb::FieldCodec.ForMessage(50, global::Apollo.Hdmap.Signal.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Signal> signal_ = new pbc::RepeatedField<global::Apollo.Hdmap.Signal>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Signal> Signal {
      get { return signal_; }
    }

    /// <summary>Field number for the "yield" field.</summary>
    public const int YieldFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.YieldSign> _repeated_yield_codec
        = pb::FieldCodec.ForMessage(58, global::Apollo.Hdmap.YieldSign.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.YieldSign> yield_ = new pbc::RepeatedField<global::Apollo.Hdmap.YieldSign>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.YieldSign> Yield {
      get { return yield_; }
    }

    /// <summary>Field number for the "overlap" field.</summary>
    public const int OverlapFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Overlap> _repeated_overlap_codec
        = pb::FieldCodec.ForMessage(66, global::Apollo.Hdmap.Overlap.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Overlap> overlap_ = new pbc::RepeatedField<global::Apollo.Hdmap.Overlap>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Overlap> Overlap {
      get { return overlap_; }
    }

    /// <summary>Field number for the "clear_area" field.</summary>
    public const int ClearAreaFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.ClearArea> _repeated_clearArea_codec
        = pb::FieldCodec.ForMessage(74, global::Apollo.Hdmap.ClearArea.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.ClearArea> clearArea_ = new pbc::RepeatedField<global::Apollo.Hdmap.ClearArea>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.ClearArea> ClearArea {
      get { return clearArea_; }
    }

    /// <summary>Field number for the "speed_bump" field.</summary>
    public const int SpeedBumpFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.SpeedBump> _repeated_speedBump_codec
        = pb::FieldCodec.ForMessage(82, global::Apollo.Hdmap.SpeedBump.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.SpeedBump> speedBump_ = new pbc::RepeatedField<global::Apollo.Hdmap.SpeedBump>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.SpeedBump> SpeedBump {
      get { return speedBump_; }
    }

    /// <summary>Field number for the "road" field.</summary>
    public const int RoadFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Road> _repeated_road_codec
        = pb::FieldCodec.ForMessage(90, global::Apollo.Hdmap.Road.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Road> road_ = new pbc::RepeatedField<global::Apollo.Hdmap.Road>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Road> Road {
      get { return road_; }
    }

    /// <summary>Field number for the "parking_space" field.</summary>
    public const int ParkingSpaceFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.ParkingSpace> _repeated_parkingSpace_codec
        = pb::FieldCodec.ForMessage(98, global::Apollo.Hdmap.ParkingSpace.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.ParkingSpace> parkingSpace_ = new pbc::RepeatedField<global::Apollo.Hdmap.ParkingSpace>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.ParkingSpace> ParkingSpace {
      get { return parkingSpace_; }
    }

    /// <summary>Field number for the "pnc_junction" field.</summary>
    public const int PncJunctionFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.PNCJunction> _repeated_pncJunction_codec
        = pb::FieldCodec.ForMessage(106, global::Apollo.Hdmap.PNCJunction.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.PNCJunction> pncJunction_ = new pbc::RepeatedField<global::Apollo.Hdmap.PNCJunction>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.PNCJunction> PncJunction {
      get { return pncJunction_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Map);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Map other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if(!crosswalk_.Equals(other.crosswalk_)) return false;
      if(!junction_.Equals(other.junction_)) return false;
      if(!lane_.Equals(other.lane_)) return false;
      if(!stopSign_.Equals(other.stopSign_)) return false;
      if(!signal_.Equals(other.signal_)) return false;
      if(!yield_.Equals(other.yield_)) return false;
      if(!overlap_.Equals(other.overlap_)) return false;
      if(!clearArea_.Equals(other.clearArea_)) return false;
      if(!speedBump_.Equals(other.speedBump_)) return false;
      if(!road_.Equals(other.road_)) return false;
      if(!parkingSpace_.Equals(other.parkingSpace_)) return false;
      if(!pncJunction_.Equals(other.pncJunction_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      hash ^= crosswalk_.GetHashCode();
      hash ^= junction_.GetHashCode();
      hash ^= lane_.GetHashCode();
      hash ^= stopSign_.GetHashCode();
      hash ^= signal_.GetHashCode();
      hash ^= yield_.GetHashCode();
      hash ^= overlap_.GetHashCode();
      hash ^= clearArea_.GetHashCode();
      hash ^= speedBump_.GetHashCode();
      hash ^= road_.GetHashCode();
      hash ^= parkingSpace_.GetHashCode();
      hash ^= pncJunction_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      crosswalk_.WriteTo(output, _repeated_crosswalk_codec);
      junction_.WriteTo(output, _repeated_junction_codec);
      lane_.WriteTo(output, _repeated_lane_codec);
      stopSign_.WriteTo(output, _repeated_stopSign_codec);
      signal_.WriteTo(output, _repeated_signal_codec);
      yield_.WriteTo(output, _repeated_yield_codec);
      overlap_.WriteTo(output, _repeated_overlap_codec);
      clearArea_.WriteTo(output, _repeated_clearArea_codec);
      speedBump_.WriteTo(output, _repeated_speedBump_codec);
      road_.WriteTo(output, _repeated_road_codec);
      parkingSpace_.WriteTo(output, _repeated_parkingSpace_codec);
      pncJunction_.WriteTo(output, _repeated_pncJunction_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      size += crosswalk_.CalculateSize(_repeated_crosswalk_codec);
      size += junction_.CalculateSize(_repeated_junction_codec);
      size += lane_.CalculateSize(_repeated_lane_codec);
      size += stopSign_.CalculateSize(_repeated_stopSign_codec);
      size += signal_.CalculateSize(_repeated_signal_codec);
      size += yield_.CalculateSize(_repeated_yield_codec);
      size += overlap_.CalculateSize(_repeated_overlap_codec);
      size += clearArea_.CalculateSize(_repeated_clearArea_codec);
      size += speedBump_.CalculateSize(_repeated_speedBump_codec);
      size += road_.CalculateSize(_repeated_road_codec);
      size += parkingSpace_.CalculateSize(_repeated_parkingSpace_codec);
      size += pncJunction_.CalculateSize(_repeated_pncJunction_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Map other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          header_ = new global::Apollo.Hdmap.Header();
        }
        Header.MergeFrom(other.Header);
      }
      crosswalk_.Add(other.crosswalk_);
      junction_.Add(other.junction_);
      lane_.Add(other.lane_);
      stopSign_.Add(other.stopSign_);
      signal_.Add(other.signal_);
      yield_.Add(other.yield_);
      overlap_.Add(other.overlap_);
      clearArea_.Add(other.clearArea_);
      speedBump_.Add(other.speedBump_);
      road_.Add(other.road_);
      parkingSpace_.Add(other.parkingSpace_);
      pncJunction_.Add(other.pncJunction_);
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
            if (header_ == null) {
              header_ = new global::Apollo.Hdmap.Header();
            }
            input.ReadMessage(header_);
            break;
          }
          case 18: {
            crosswalk_.AddEntriesFrom(input, _repeated_crosswalk_codec);
            break;
          }
          case 26: {
            junction_.AddEntriesFrom(input, _repeated_junction_codec);
            break;
          }
          case 34: {
            lane_.AddEntriesFrom(input, _repeated_lane_codec);
            break;
          }
          case 42: {
            stopSign_.AddEntriesFrom(input, _repeated_stopSign_codec);
            break;
          }
          case 50: {
            signal_.AddEntriesFrom(input, _repeated_signal_codec);
            break;
          }
          case 58: {
            yield_.AddEntriesFrom(input, _repeated_yield_codec);
            break;
          }
          case 66: {
            overlap_.AddEntriesFrom(input, _repeated_overlap_codec);
            break;
          }
          case 74: {
            clearArea_.AddEntriesFrom(input, _repeated_clearArea_codec);
            break;
          }
          case 82: {
            speedBump_.AddEntriesFrom(input, _repeated_speedBump_codec);
            break;
          }
          case 90: {
            road_.AddEntriesFrom(input, _repeated_road_codec);
            break;
          }
          case 98: {
            parkingSpace_.AddEntriesFrom(input, _repeated_parkingSpace_codec);
            break;
          }
          case 106: {
            pncJunction_.AddEntriesFrom(input, _repeated_pncJunction_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
