// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Request.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Library.Inputs.Contracts {

  /// <summary>Holder for reflection information generated from Request.proto</summary>
  public static partial class RequestReflection {

    #region Descriptor
    /// <summary>File descriptor for Request.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1SZXF1ZXN0LnByb3RvEgljb250cmFjdHMaJmluY2x1ZGUvZ29vZ2xlL3By",
            "b3RvYnVmL2R1cmF0aW9uLnByb3RvGiZpbmNsdWRlL2dvb2dsZS9wcm90b2J1",
            "Zi93cmFwcGVycy5wcm90byKZAwoHUmVxdWVzdBILCgN2ZXIYASABKAUSCgoC",
            "aWQYAiABKAkSKwoIZHVyYXRpb24YAyABKAsyGS5nb29nbGUucHJvdG9idWYu",
            "RHVyYXRpb24SFAoMcmVzcG9uc2VDb2RlGAQgASgJEisKB3N1Y2Nlc3MYBSAB",
            "KAsyGi5nb29nbGUucHJvdG9idWYuQm9vbFZhbHVlEg4KBnNvdXJjZRgGIAEo",
            "CRIMCgRuYW1lGAcgASgJEgsKA3VybBgIIAEoCRI2Cgpwcm9wZXJ0aWVzGAkg",
            "AygLMiIuY29udHJhY3RzLlJlcXVlc3QuUHJvcGVydGllc0VudHJ5EjoKDG1l",
            "YXN1cmVtZW50cxgKIAMoCzIkLmNvbnRyYWN0cy5SZXF1ZXN0Lk1lYXN1cmVt",
            "ZW50c0VudHJ5GjEKD1Byb3BlcnRpZXNFbnRyeRILCgNrZXkYASABKAkSDQoF",
            "dmFsdWUYAiABKAk6AjgBGjMKEU1lYXN1cmVtZW50c0VudHJ5EgsKA2tleRgB",
            "IAEoCRINCgV2YWx1ZRgCIAEoAToCOAFCG6oCGExpYnJhcnkuSW5wdXRzLkNv",
            "bnRyYWN0c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Library.Inputs.Contracts.Request), global::Library.Inputs.Contracts.Request.Parser, new[]{ "Ver", "Id", "Duration", "ResponseCode", "Success", "Source", "Name", "Url", "Properties", "Measurements" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Request : pb::IMessage<Request> {
    private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Request> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Library.Inputs.Contracts.RequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request(Request other) : this() {
      ver_ = other.ver_;
      id_ = other.id_;
      Duration = other.duration_ != null ? other.Duration.Clone() : null;
      responseCode_ = other.responseCode_;
      Success = other.success_ != null ? other.Success.Clone() : null;
      source_ = other.source_;
      name_ = other.name_;
      url_ = other.url_;
      properties_ = other.properties_.Clone();
      measurements_ = other.measurements_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request Clone() {
      return new Request(this);
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

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    /// <summary>Field number for the "responseCode" field.</summary>
    public const int ResponseCodeFieldNumber = 4;
    private string responseCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResponseCode {
      get { return responseCode_; }
      set {
        responseCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.BoolValue success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.BoolValue Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 6;
    private string source_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Source {
      get { return source_; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 7;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 8;
    private string url_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 9;
    private static readonly pbc::MapField<string, string>.Codec _map_properties_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 74);
    private readonly pbc::MapField<string, string> properties_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Properties {
      get { return properties_; }
    }

    /// <summary>Field number for the "measurements" field.</summary>
    public const int MeasurementsFieldNumber = 10;
    private static readonly pbc::MapField<string, double>.Codec _map_measurements_codec
        = new pbc::MapField<string, double>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForDouble(17), 82);
    private readonly pbc::MapField<string, double> measurements_ = new pbc::MapField<string, double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, double> Measurements {
      get { return measurements_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Request);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ver != other.Ver) return false;
      if (Id != other.Id) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      if (ResponseCode != other.ResponseCode) return false;
      if (!object.Equals(Success, other.Success)) return false;
      if (Source != other.Source) return false;
      if (Name != other.Name) return false;
      if (Url != other.Url) return false;
      if (!Properties.Equals(other.Properties)) return false;
      if (!Measurements.Equals(other.Measurements)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ver != 0) hash ^= Ver.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
      if (ResponseCode.Length != 0) hash ^= ResponseCode.GetHashCode();
      if (success_ != null) hash ^= Success.GetHashCode();
      if (Source.Length != 0) hash ^= Source.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Url.Length != 0) hash ^= Url.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (duration_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Duration);
      }
      if (ResponseCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ResponseCode);
      }
      if (success_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Success);
      }
      if (Source.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Source);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Name);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Url);
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
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (duration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      if (ResponseCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResponseCode);
      }
      if (success_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Success);
      }
      if (Source.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Source);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      size += properties_.CalculateSize(_map_properties_codec);
      size += measurements_.CalculateSize(_map_measurements_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Request other) {
      if (other == null) {
        return;
      }
      if (other.Ver != 0) {
        Ver = other.Ver;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
      }
      if (other.ResponseCode.Length != 0) {
        ResponseCode = other.ResponseCode;
      }
      if (other.success_ != null) {
        if (success_ == null) {
          success_ = new global::Google.Protobuf.WellKnownTypes.BoolValue();
        }
        Success.MergeFrom(other.Success);
      }
      if (other.Source.Length != 0) {
        Source = other.Source;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
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
            Id = input.ReadString();
            break;
          }
          case 26: {
            if (duration_ == null) {
              duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(duration_);
            break;
          }
          case 34: {
            ResponseCode = input.ReadString();
            break;
          }
          case 42: {
            if (success_ == null) {
              success_ = new global::Google.Protobuf.WellKnownTypes.BoolValue();
            }
            input.ReadMessage(success_);
            break;
          }
          case 50: {
            Source = input.ReadString();
            break;
          }
          case 58: {
            Name = input.ReadString();
            break;
          }
          case 66: {
            Url = input.ReadString();
            break;
          }
          case 74: {
            properties_.AddEntriesFrom(input, _map_properties_codec);
            break;
          }
          case 82: {
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
