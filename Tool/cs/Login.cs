// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Login.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protobuf {

  /// <summary>Holder for reflection information generated from Login.proto</summary>
  public static partial class LoginReflection {

    #region Descriptor
    /// <summary>File descriptor for Login.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoginReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtMb2dpbi5wcm90bxIIcHJvdG9idWYiMAoFTG9naW4SCgoCaWQYASABKAkS",
            "DAoEdGltZRgCIAEoAxINCgV0b2tlbhgDIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protobuf.Login), global::Protobuf.Login.Parser, new[]{ "Id", "Time", "Token" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Login : pb::IMessage<Login> {
    private static readonly pb::MessageParser<Login> _parser = new pb::MessageParser<Login>(() => new Login());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Login> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protobuf.LoginReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Login() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Login(Login other) : this() {
      id_ = other.id_;
      time_ = other.time_;
      token_ = other.token_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Login Clone() {
      return new Login(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// request
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 2;
    private long time_;
    /// <summary>
    /// response
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 3;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Login);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Login other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Time != other.Time) return false;
      if (Token != other.Token) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Time != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Time);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Token);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Login other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
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
            Id = input.ReadString();
            break;
          }
          case 16: {
            Time = input.ReadInt64();
            break;
          }
          case 26: {
            Token = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code