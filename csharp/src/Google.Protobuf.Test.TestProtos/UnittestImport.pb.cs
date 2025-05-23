// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: csharp/protos/unittest_import.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.TestProtos.Proto2 {

  /// <summary>Holder for reflection information generated from csharp/protos/unittest_import.proto</summary>
  public static partial class UnittestImportReflection {

    #region Descriptor
    /// <summary>File descriptor for csharp/protos/unittest_import.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnittestImportReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNjc2hhcnAvcHJvdG9zL3VuaXR0ZXN0X2ltcG9ydC5wcm90bxIfcHJvdG9i",
            "dWZfdW5pdHRlc3RfaW1wb3J0X3Byb3RvMhoqY3NoYXJwL3Byb3Rvcy91bml0",
            "dGVzdF9pbXBvcnRfcHVibGljLnByb3RvIhoKDUltcG9ydE1lc3NhZ2USCQoB",
            "ZBgBIAEoBSo8CgpJbXBvcnRFbnVtEg4KCklNUE9SVF9GT08QBxIOCgpJTVBP",
            "UlRfQkFSEAgSDgoKSU1QT1JUX0JBWhAJKjEKEEltcG9ydEVudW1Gb3JNYXAS",
            "CwoHVU5LTk9XThAAEgcKA0ZPTxABEgcKA0JBUhACQilIAfgBAaoCIUdvb2ds",
            "ZS5Qcm90b2J1Zi5UZXN0UHJvdG9zLlByb3RvMlAA"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.TestProtos.Proto2.UnittestImportPublicReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Protobuf.TestProtos.Proto2.ImportEnum), typeof(global::Google.Protobuf.TestProtos.Proto2.ImportEnumForMap), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.TestProtos.Proto2.ImportMessage), global::Google.Protobuf.TestProtos.Proto2.ImportMessage.Parser, new[]{ "D" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ImportEnum {
    [pbr::OriginalName("IMPORT_FOO")] ImportFoo = 7,
    [pbr::OriginalName("IMPORT_BAR")] ImportBar = 8,
    [pbr::OriginalName("IMPORT_BAZ")] ImportBaz = 9,
  }

  /// <summary>
  /// To use an enum in a map, it must has the first value as 0.
  /// </summary>
  public enum ImportEnumForMap {
    [pbr::OriginalName("UNKNOWN")] Unknown = 0,
    [pbr::OriginalName("FOO")] Foo = 1,
    [pbr::OriginalName("BAR")] Bar = 2,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ImportMessage : pb::IMessage<ImportMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ImportMessage> _parser = new pb::MessageParser<ImportMessage>(() => new ImportMessage());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ImportMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.TestProtos.Proto2.UnittestImportReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImportMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImportMessage(ImportMessage other) : this() {
      _hasBits0 = other._hasBits0;
      d_ = other.d_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImportMessage Clone() {
      return new ImportMessage(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void Clear() {
      _hasBits0 = 0;
      d_ = 0;
      if (_unknownFields != null) {
        _unknownFields.Clear();
      }
    }

    /// <summary>Field number for the "d" field.</summary>
    public const int DFieldNumber = 1;
    private readonly static int DDefaultValue = 0;

    private int d_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int D {
      get { if ((_hasBits0 & 1) != 0) { return d_; } else { return DDefaultValue; } }
      set {
        _hasBits0 |= 1;
        d_ = value;
      }
    }
    /// <summary>Gets whether the "d" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasD {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "d" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearD() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ImportMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ImportMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (D != other.D) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasD) hash ^= D.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasD) {
        output.WriteRawTag(8);
        output.WriteInt32(D);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasD) {
        output.WriteRawTag(8);
        output.WriteInt32(D);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasD) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(D);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ImportMessage other) {
      if (other == null) {
        return;
      }
      if (other.HasD) {
        D = other.D;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            D = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            D = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
