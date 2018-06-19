// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Dependency.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Library.Inputs.Contracts {

  /// <summary>Holder for reflection information generated from Dependency.proto</summary>
  public static partial class DependencyReflection {

    #region Descriptor
    /// <summary>File descriptor for Dependency.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DependencyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBEZXBlbmRlbmN5LnByb3RvEgljb250cmFjdHMaJmluY2x1ZGUvZ29vZ2xl",
            "L3Byb3RvYnVmL2R1cmF0aW9uLnByb3RvGiZpbmNsdWRlL2dvb2dsZS9wcm90",
            "b2J1Zi93cmFwcGVycy5wcm90byKvAwoKRGVwZW5kZW5jeRILCgN2ZXIYASAB",
            "KAUSDAoEbmFtZRgCIAEoCRIKCgJpZBgDIAEoCRISCgpyZXN1bHRDb2RlGAQg",
            "ASgJEisKCGR1cmF0aW9uGAUgASgLMhkuZ29vZ2xlLnByb3RvYnVmLkR1cmF0",
            "aW9uEisKB3N1Y2Nlc3MYBiABKAsyGi5nb29nbGUucHJvdG9idWYuQm9vbFZh",
            "bHVlEgwKBGRhdGEYByABKAkSDAoEdHlwZRgIIAEoCRIOCgZ0YXJnZXQYCSAB",
            "KAkSOQoKcHJvcGVydGllcxgKIAMoCzIlLmNvbnRyYWN0cy5EZXBlbmRlbmN5",
            "LlByb3BlcnRpZXNFbnRyeRI9CgxtZWFzdXJlbWVudHMYCyADKAsyJy5jb250",
            "cmFjdHMuRGVwZW5kZW5jeS5NZWFzdXJlbWVudHNFbnRyeRoxCg9Qcm9wZXJ0",
            "aWVzRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ARozChFN",
            "ZWFzdXJlbWVudHNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAE6",
            "AjgBQhuqAhhMaWJyYXJ5LklucHV0cy5Db250cmFjdHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Library.Inputs.Contracts.Dependency), global::Library.Inputs.Contracts.Dependency.Parser, new[]{ "Ver", "Name", "Id", "ResultCode", "Duration", "Success", "Data", "Type", "Target", "Properties", "Measurements" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Dependency : pb::IMessage<Dependency> {
    private static readonly pb::MessageParser<Dependency> _parser = new pb::MessageParser<Dependency>(() => new Dependency());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Dependency> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Library.Inputs.Contracts.DependencyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Dependency() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Dependency(Dependency other) : this() {
      ver_ = other.ver_;
      name_ = other.name_;
      id_ = other.id_;
      resultCode_ = other.resultCode_;
      Duration = other.duration_ != null ? other.Duration.Clone() : null;
      Success = other.success_ != null ? other.Success.Clone() : null;
      data_ = other.data_;
      type_ = other.type_;
      target_ = other.target_;
      properties_ = other.properties_.Clone();
      measurements_ = other.measurements_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Dependency Clone() {
      return new Dependency(this);
    }

    /// <summary>Field number for the "ver" field.</summary>
    public const int VerFieldNumber = 1;
    private int ver_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Ver {
      get { return ver_; }
      set {
        ver_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resultCode" field.</summary>
    public const int ResultCodeFieldNumber = 4;
    private string resultCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResultCode {
      get { return resultCode_; }
      set {
        resultCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.BoolValue success_;
    /// <summary>
    /// the default is interpreted as true
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.BoolValue Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 7;
    private string data_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 8;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 9;
    private string target_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Target {
      get { return target_; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 10;
    private static readonly pbc::MapField<string, string>.Codec _map_properties_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 82);
    private readonly pbc::MapField<string, string> properties_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Properties {
      get { return properties_; }
    }

    /// <summary>Field number for the "measurements" field.</summary>
    public const int MeasurementsFieldNumber = 11;
    private static readonly pbc::MapField<string, double>.Codec _map_measurements_codec
        = new pbc::MapField<string, double>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForDouble(17), 90);
    private readonly pbc::MapField<string, double> measurements_ = new pbc::MapField<string, double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, double> Measurements {
      get { return measurements_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Dependency);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Dependency other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ver != other.Ver) return false;
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (ResultCode != other.ResultCode) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      if (!object.Equals(Success, other.Success)) return false;
      if (Data != other.Data) return false;
      if (Type != other.Type) return false;
      if (Target != other.Target) return false;
      if (!Properties.Equals(other.Properties)) return false;
      if (!Measurements.Equals(other.Measurements)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ver != 0) hash ^= Ver.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (ResultCode.Length != 0) hash ^= ResultCode.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
      if (success_ != null) hash ^= Success.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Target.Length != 0) hash ^= Target.GetHashCode();
      hash ^= Properties.GetHashCode();
      hash ^= Measurements.GetHashCode();
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
      if (Ver != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Ver);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Id);
      }
      if (ResultCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ResultCode);
      }
      if (duration_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Duration);
      }
      if (success_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Success);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Data);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Type);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Target);
      }
      properties_.WriteTo(output, _map_properties_codec);
      measurements_.WriteTo(output, _map_measurements_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ver != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Ver);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (ResultCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResultCode);
      }
      if (duration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      if (success_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Success);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Data);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Target.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Target);
      }
      size += properties_.CalculateSize(_map_properties_codec);
      size += measurements_.CalculateSize(_map_measurements_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Dependency other) {
      if (other == null) {
        return;
      }
      if (other.Ver != 0) {
        Ver = other.Ver;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.ResultCode.Length != 0) {
        ResultCode = other.ResultCode;
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
      }
      if (other.success_ != null) {
        if (success_ == null) {
          success_ = new global::Google.Protobuf.WellKnownTypes.BoolValue();
        }
        Success.MergeFrom(other.Success);
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Target.Length != 0) {
        Target = other.Target;
      }
      properties_.Add(other.properties_);
      measurements_.Add(other.measurements_);
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
            Ver = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Id = input.ReadString();
            break;
          }
          case 34: {
            ResultCode = input.ReadString();
            break;
          }
          case 42: {
            if (duration_ == null) {
              duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(duration_);
            break;
          }
          case 50: {
            if (success_ == null) {
              success_ = new global::Google.Protobuf.WellKnownTypes.BoolValue();
            }
            input.ReadMessage(success_);
            break;
          }
          case 58: {
            Data = input.ReadString();
            break;
          }
          case 66: {
            Type = input.ReadString();
            break;
          }
          case 74: {
            Target = input.ReadString();
            break;
          }
          case 82: {
            properties_.AddEntriesFrom(input, _map_properties_codec);
            break;
          }
          case 90: {
            measurements_.AddEntriesFrom(input, _map_measurements_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
