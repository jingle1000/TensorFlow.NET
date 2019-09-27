// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: object_detection/protos/flexible_grid_anchor_generator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Models.ObjectDetection.Protos {

  /// <summary>Holder for reflection information generated from object_detection/protos/flexible_grid_anchor_generator.proto</summary>
  public static partial class FlexibleGridAnchorGeneratorReflection {

    #region Descriptor
    /// <summary>File descriptor for object_detection/protos/flexible_grid_anchor_generator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FlexibleGridAnchorGeneratorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxvYmplY3RfZGV0ZWN0aW9uL3Byb3Rvcy9mbGV4aWJsZV9ncmlkX2FuY2hv",
            "cl9nZW5lcmF0b3IucHJvdG8SF29iamVjdF9kZXRlY3Rpb24ucHJvdG9zInYK",
            "G0ZsZXhpYmxlR3JpZEFuY2hvckdlbmVyYXRvchI4CgthbmNob3JfZ3JpZBgB",
            "IAMoCzIjLm9iamVjdF9kZXRlY3Rpb24ucHJvdG9zLkFuY2hvckdyaWQSHQoV",
            "bm9ybWFsaXplX2Nvb3JkaW5hdGVzGAIgASgIIpEBCgpBbmNob3JHcmlkEhIK",
            "CmJhc2Vfc2l6ZXMYASADKAISFQoNYXNwZWN0X3JhdGlvcxgCIAMoAhIVCg1o",
            "ZWlnaHRfc3RyaWRlGAMgASgNEhQKDHdpZHRoX3N0cmlkZRgEIAEoDRIVCg1o",
            "ZWlnaHRfb2Zmc2V0GAUgASgNEhQKDHdpZHRoX29mZnNldBgGIAEoDWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Models.ObjectDetection.Protos.FlexibleGridAnchorGenerator), global::Tensorflow.Models.ObjectDetection.Protos.FlexibleGridAnchorGenerator.Parser, new[]{ "AnchorGrid", "NormalizeCoordinates" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Models.ObjectDetection.Protos.AnchorGrid), global::Tensorflow.Models.ObjectDetection.Protos.AnchorGrid.Parser, new[]{ "BaseSizes", "AspectRatios", "HeightStride", "WidthStride", "HeightOffset", "WidthOffset" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FlexibleGridAnchorGenerator : pb::IMessage<FlexibleGridAnchorGenerator> {
    private static readonly pb::MessageParser<FlexibleGridAnchorGenerator> _parser = new pb::MessageParser<FlexibleGridAnchorGenerator>(() => new FlexibleGridAnchorGenerator());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FlexibleGridAnchorGenerator> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Models.ObjectDetection.Protos.FlexibleGridAnchorGeneratorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FlexibleGridAnchorGenerator() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FlexibleGridAnchorGenerator(FlexibleGridAnchorGenerator other) : this() {
      anchorGrid_ = other.anchorGrid_.Clone();
      normalizeCoordinates_ = other.normalizeCoordinates_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FlexibleGridAnchorGenerator Clone() {
      return new FlexibleGridAnchorGenerator(this);
    }

    /// <summary>Field number for the "anchor_grid" field.</summary>
    public const int AnchorGridFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Tensorflow.Models.ObjectDetection.Protos.AnchorGrid> _repeated_anchorGrid_codec
        = pb::FieldCodec.ForMessage(10, global::Tensorflow.Models.ObjectDetection.Protos.AnchorGrid.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.Models.ObjectDetection.Protos.AnchorGrid> anchorGrid_ = new pbc::RepeatedField<global::Tensorflow.Models.ObjectDetection.Protos.AnchorGrid>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.Models.ObjectDetection.Protos.AnchorGrid> AnchorGrid {
      get { return anchorGrid_; }
    }

    /// <summary>Field number for the "normalize_coordinates" field.</summary>
    public const int NormalizeCoordinatesFieldNumber = 2;
    private bool normalizeCoordinates_;
    /// <summary>
    /// Whether to produce anchors in normalized coordinates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool NormalizeCoordinates {
      get { return normalizeCoordinates_; }
      set {
        normalizeCoordinates_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FlexibleGridAnchorGenerator);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FlexibleGridAnchorGenerator other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!anchorGrid_.Equals(other.anchorGrid_)) return false;
      if (NormalizeCoordinates != other.NormalizeCoordinates) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= anchorGrid_.GetHashCode();
      if (NormalizeCoordinates != false) hash ^= NormalizeCoordinates.GetHashCode();
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
      anchorGrid_.WriteTo(output, _repeated_anchorGrid_codec);
      if (NormalizeCoordinates != false) {
        output.WriteRawTag(16);
        output.WriteBool(NormalizeCoordinates);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += anchorGrid_.CalculateSize(_repeated_anchorGrid_codec);
      if (NormalizeCoordinates != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FlexibleGridAnchorGenerator other) {
      if (other == null) {
        return;
      }
      anchorGrid_.Add(other.anchorGrid_);
      if (other.NormalizeCoordinates != false) {
        NormalizeCoordinates = other.NormalizeCoordinates;
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
            anchorGrid_.AddEntriesFrom(input, _repeated_anchorGrid_codec);
            break;
          }
          case 16: {
            NormalizeCoordinates = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AnchorGrid : pb::IMessage<AnchorGrid> {
    private static readonly pb::MessageParser<AnchorGrid> _parser = new pb::MessageParser<AnchorGrid>(() => new AnchorGrid());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AnchorGrid> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Models.ObjectDetection.Protos.FlexibleGridAnchorGeneratorReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnchorGrid() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnchorGrid(AnchorGrid other) : this() {
      baseSizes_ = other.baseSizes_.Clone();
      aspectRatios_ = other.aspectRatios_.Clone();
      heightStride_ = other.heightStride_;
      widthStride_ = other.widthStride_;
      heightOffset_ = other.heightOffset_;
      widthOffset_ = other.widthOffset_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnchorGrid Clone() {
      return new AnchorGrid(this);
    }

    /// <summary>Field number for the "base_sizes" field.</summary>
    public const int BaseSizesFieldNumber = 1;
    private static readonly pb::FieldCodec<float> _repeated_baseSizes_codec
        = pb::FieldCodec.ForFloat(10);
    private readonly pbc::RepeatedField<float> baseSizes_ = new pbc::RepeatedField<float>();
    /// <summary>
    /// The base sizes in pixels for each anchor in this anchor layer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> BaseSizes {
      get { return baseSizes_; }
    }

    /// <summary>Field number for the "aspect_ratios" field.</summary>
    public const int AspectRatiosFieldNumber = 2;
    private static readonly pb::FieldCodec<float> _repeated_aspectRatios_codec
        = pb::FieldCodec.ForFloat(18);
    private readonly pbc::RepeatedField<float> aspectRatios_ = new pbc::RepeatedField<float>();
    /// <summary>
    /// The aspect ratios for each anchor in this anchor layer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> AspectRatios {
      get { return aspectRatios_; }
    }

    /// <summary>Field number for the "height_stride" field.</summary>
    public const int HeightStrideFieldNumber = 3;
    private uint heightStride_;
    /// <summary>
    /// The anchor height stride in pixels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint HeightStride {
      get { return heightStride_; }
      set {
        heightStride_ = value;
      }
    }

    /// <summary>Field number for the "width_stride" field.</summary>
    public const int WidthStrideFieldNumber = 4;
    private uint widthStride_;
    /// <summary>
    /// The anchor width stride in pixels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint WidthStride {
      get { return widthStride_; }
      set {
        widthStride_ = value;
      }
    }

    /// <summary>Field number for the "height_offset" field.</summary>
    public const int HeightOffsetFieldNumber = 5;
    private uint heightOffset_;
    /// <summary>
    /// The anchor height offset in pixels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint HeightOffset {
      get { return heightOffset_; }
      set {
        heightOffset_ = value;
      }
    }

    /// <summary>Field number for the "width_offset" field.</summary>
    public const int WidthOffsetFieldNumber = 6;
    private uint widthOffset_;
    /// <summary>
    /// The anchor width offset in pixels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint WidthOffset {
      get { return widthOffset_; }
      set {
        widthOffset_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AnchorGrid);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AnchorGrid other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!baseSizes_.Equals(other.baseSizes_)) return false;
      if(!aspectRatios_.Equals(other.aspectRatios_)) return false;
      if (HeightStride != other.HeightStride) return false;
      if (WidthStride != other.WidthStride) return false;
      if (HeightOffset != other.HeightOffset) return false;
      if (WidthOffset != other.WidthOffset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= baseSizes_.GetHashCode();
      hash ^= aspectRatios_.GetHashCode();
      if (HeightStride != 0) hash ^= HeightStride.GetHashCode();
      if (WidthStride != 0) hash ^= WidthStride.GetHashCode();
      if (HeightOffset != 0) hash ^= HeightOffset.GetHashCode();
      if (WidthOffset != 0) hash ^= WidthOffset.GetHashCode();
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
      baseSizes_.WriteTo(output, _repeated_baseSizes_codec);
      aspectRatios_.WriteTo(output, _repeated_aspectRatios_codec);
      if (HeightStride != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(HeightStride);
      }
      if (WidthStride != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WidthStride);
      }
      if (HeightOffset != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HeightOffset);
      }
      if (WidthOffset != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(WidthOffset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += baseSizes_.CalculateSize(_repeated_baseSizes_codec);
      size += aspectRatios_.CalculateSize(_repeated_aspectRatios_codec);
      if (HeightStride != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeightStride);
      }
      if (WidthStride != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WidthStride);
      }
      if (HeightOffset != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeightOffset);
      }
      if (WidthOffset != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WidthOffset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AnchorGrid other) {
      if (other == null) {
        return;
      }
      baseSizes_.Add(other.baseSizes_);
      aspectRatios_.Add(other.aspectRatios_);
      if (other.HeightStride != 0) {
        HeightStride = other.HeightStride;
      }
      if (other.WidthStride != 0) {
        WidthStride = other.WidthStride;
      }
      if (other.HeightOffset != 0) {
        HeightOffset = other.HeightOffset;
      }
      if (other.WidthOffset != 0) {
        WidthOffset = other.WidthOffset;
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
          case 10:
          case 13: {
            baseSizes_.AddEntriesFrom(input, _repeated_baseSizes_codec);
            break;
          }
          case 18:
          case 21: {
            aspectRatios_.AddEntriesFrom(input, _repeated_aspectRatios_codec);
            break;
          }
          case 24: {
            HeightStride = input.ReadUInt32();
            break;
          }
          case 32: {
            WidthStride = input.ReadUInt32();
            break;
          }
          case 40: {
            HeightOffset = input.ReadUInt32();
            break;
          }
          case 48: {
            WidthOffset = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
