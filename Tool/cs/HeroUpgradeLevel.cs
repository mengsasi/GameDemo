// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Hero_Upgrade_Level.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protobuf {

  /// <summary>Holder for reflection information generated from Hero_Upgrade_Level.proto</summary>
  public static partial class HeroUpgradeLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for Hero_Upgrade_Level.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeroUpgradeLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhIZXJvX1VwZ3JhZGVfTGV2ZWwucHJvdG8SCHByb3RvYnVmGgpJdGVtLnBy",
            "b3RvIk4KEkhlcm9fVXBncmFkZV9MZXZlbBIKCgJpZBgBIAEoCRINCgVsZXZl",
            "bBgCIAEoBRIdCgVpdGVtcxgDIAMoCzIOLnByb3RvYnVmLkl0ZW1iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Protobuf.ItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protobuf.Hero_Upgrade_Level), global::Protobuf.Hero_Upgrade_Level.Parser, new[]{ "Id", "Level", "Items" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Hero_Upgrade_Level : pb::IMessage<Hero_Upgrade_Level> {
    private static readonly pb::MessageParser<Hero_Upgrade_Level> _parser = new pb::MessageParser<Hero_Upgrade_Level>(() => new Hero_Upgrade_Level());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Hero_Upgrade_Level> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protobuf.HeroUpgradeLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hero_Upgrade_Level() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hero_Upgrade_Level(Hero_Upgrade_Level other) : this() {
      id_ = other.id_;
      level_ = other.level_;
      items_ = other.items_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hero_Upgrade_Level Clone() {
      return new Hero_Upgrade_Level(this);
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

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 2;
    private int level_;
    /// <summary>
    /// response
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Protobuf.Item> _repeated_items_codec
        = pb::FieldCodec.ForMessage(26, global::Protobuf.Item.Parser);
    private readonly pbc::RepeatedField<global::Protobuf.Item> items_ = new pbc::RepeatedField<global::Protobuf.Item>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Protobuf.Item> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Hero_Upgrade_Level);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Hero_Upgrade_Level other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Level != other.Level) return false;
      if(!items_.Equals(other.items_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      hash ^= items_.GetHashCode();
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
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Level);
      }
      items_.WriteTo(output, _repeated_items_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      size += items_.CalculateSize(_repeated_items_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Hero_Upgrade_Level other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      items_.Add(other.items_);
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
            Level = input.ReadInt32();
            break;
          }
          case 26: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
