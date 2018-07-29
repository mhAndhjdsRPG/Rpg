// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Store.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Gamedef {

  /// <summary>Holder for reflection information generated from Store.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class StoreReflection {

    #region Descriptor
    /// <summary>File descriptor for Store.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtTdG9yZS5wcm90bxIHZ2FtZWRlZiIhCg9CdXlTdG9yZUl0ZW1SZXESDgoG",
            "SXRlbUlEGAEgASgNIkUKD0J1eVN0b3JlSXRlbUFjaxIOCgZSZXN1bHQYASAB",
            "KAkSDgoGSXRlbUlEGAIgASgNEhIKCkdvbGROdW1iZXIYAyABKA0iTgoOU3Rv",
            "cmVfSXRlbUluZm8SEQoJRGVzcGV0aW9uGAEgASgJEgwKBE5hbWUYAiABKAkS",
            "DQoFUHJpY2UYAyABKA0SDAoEYkJ1eRgEIAEoCCJDChJVcGRhdGVTdG9yZUl0",
            "ZW1BY2sSLQoISXRlbUxpc3QYASADKAsyFy5nYW1lZGVmLlN0b3JlX0l0ZW1J",
            "bmZvQgIQAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Gamedef.BuyStoreItemReq), global::Gamedef.BuyStoreItemReq.Parser, new[]{ "ItemID" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Gamedef.BuyStoreItemAck), global::Gamedef.BuyStoreItemAck.Parser, new[]{ "Result", "ItemID", "GoldNumber" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Gamedef.Store_ItemInfo), global::Gamedef.Store_ItemInfo.Parser, new[]{ "Despetion", "Name", "Price", "BBuy" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Gamedef.UpdateStoreItemAck), global::Gamedef.UpdateStoreItemAck.Parser, new[]{ "ItemList" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// client -> login 300
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class BuyStoreItemReq : pb::IMessage<BuyStoreItemReq> {
    private static readonly pb::MessageParser<BuyStoreItemReq> _parser = new pb::MessageParser<BuyStoreItemReq>(() => new BuyStoreItemReq());
    public static pb::MessageParser<BuyStoreItemReq> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Gamedef.StoreReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public BuyStoreItemReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    public BuyStoreItemReq(BuyStoreItemReq other) : this() {
      itemID_ = other.itemID_;
    }

    public BuyStoreItemReq Clone() {
      return new BuyStoreItemReq(this);
    }

    /// <summary>Field number for the "ItemID" field.</summary>
    public const int ItemIDFieldNumber = 1;
    private uint itemID_;
    public uint ItemID {
      get { return itemID_; }
      set {
        itemID_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as BuyStoreItemReq);
    }

    public bool Equals(BuyStoreItemReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemID != other.ItemID) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ItemID != 0) hash ^= ItemID.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemID != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemID);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ItemID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemID);
      }
      return size;
    }

    public void MergeFrom(BuyStoreItemReq other) {
      if (other == null) {
        return;
      }
      if (other.ItemID != 0) {
        ItemID = other.ItemID;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            ItemID = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// login -> client 301
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class BuyStoreItemAck : pb::IMessage<BuyStoreItemAck> {
    private static readonly pb::MessageParser<BuyStoreItemAck> _parser = new pb::MessageParser<BuyStoreItemAck>(() => new BuyStoreItemAck());
    public static pb::MessageParser<BuyStoreItemAck> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Gamedef.StoreReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public BuyStoreItemAck() {
      OnConstruction();
    }

    partial void OnConstruction();

    public BuyStoreItemAck(BuyStoreItemAck other) : this() {
      result_ = other.result_;
      itemID_ = other.itemID_;
      goldNumber_ = other.goldNumber_;
    }

    public BuyStoreItemAck Clone() {
      return new BuyStoreItemAck(this);
    }

    /// <summary>Field number for the "Result" field.</summary>
    public const int ResultFieldNumber = 1;
    private string result_ = "";
    public string Result {
      get { return result_; }
      set {
        result_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ItemID" field.</summary>
    public const int ItemIDFieldNumber = 2;
    private uint itemID_;
    public uint ItemID {
      get { return itemID_; }
      set {
        itemID_ = value;
      }
    }

    /// <summary>Field number for the "GoldNumber" field.</summary>
    public const int GoldNumberFieldNumber = 3;
    private uint goldNumber_;
    public uint GoldNumber {
      get { return goldNumber_; }
      set {
        goldNumber_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as BuyStoreItemAck);
    }

    public bool Equals(BuyStoreItemAck other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (ItemID != other.ItemID) return false;
      if (GoldNumber != other.GoldNumber) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result.Length != 0) hash ^= Result.GetHashCode();
      if (ItemID != 0) hash ^= ItemID.GetHashCode();
      if (GoldNumber != 0) hash ^= GoldNumber.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Result.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Result);
      }
      if (ItemID != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ItemID);
      }
      if (GoldNumber != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GoldNumber);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Result);
      }
      if (ItemID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemID);
      }
      if (GoldNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GoldNumber);
      }
      return size;
    }

    public void MergeFrom(BuyStoreItemAck other) {
      if (other == null) {
        return;
      }
      if (other.Result.Length != 0) {
        Result = other.Result;
      }
      if (other.ItemID != 0) {
        ItemID = other.ItemID;
      }
      if (other.GoldNumber != 0) {
        GoldNumber = other.GoldNumber;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Result = input.ReadString();
            break;
          }
          case 16: {
            ItemID = input.ReadUInt32();
            break;
          }
          case 24: {
            GoldNumber = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Store_ItemInfo : pb::IMessage<Store_ItemInfo> {
    private static readonly pb::MessageParser<Store_ItemInfo> _parser = new pb::MessageParser<Store_ItemInfo>(() => new Store_ItemInfo());
    public static pb::MessageParser<Store_ItemInfo> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Gamedef.StoreReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Store_ItemInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Store_ItemInfo(Store_ItemInfo other) : this() {
      despetion_ = other.despetion_;
      name_ = other.name_;
      price_ = other.price_;
      bBuy_ = other.bBuy_;
    }

    public Store_ItemInfo Clone() {
      return new Store_ItemInfo(this);
    }

    /// <summary>Field number for the "Despetion" field.</summary>
    public const int DespetionFieldNumber = 1;
    private string despetion_ = "";
    public string Despetion {
      get { return despetion_; }
      set {
        despetion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Price" field.</summary>
    public const int PriceFieldNumber = 3;
    private uint price_;
    public uint Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "bBuy" field.</summary>
    public const int BBuyFieldNumber = 4;
    private bool bBuy_;
    public bool BBuy {
      get { return bBuy_; }
      set {
        bBuy_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Store_ItemInfo);
    }

    public bool Equals(Store_ItemInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Despetion != other.Despetion) return false;
      if (Name != other.Name) return false;
      if (Price != other.Price) return false;
      if (BBuy != other.BBuy) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Despetion.Length != 0) hash ^= Despetion.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Price != 0) hash ^= Price.GetHashCode();
      if (BBuy != false) hash ^= BBuy.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Despetion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Despetion);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Price != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Price);
      }
      if (BBuy != false) {
        output.WriteRawTag(32);
        output.WriteBool(BBuy);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Despetion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Despetion);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Price != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Price);
      }
      if (BBuy != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(Store_ItemInfo other) {
      if (other == null) {
        return;
      }
      if (other.Despetion.Length != 0) {
        Despetion = other.Despetion;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Price != 0) {
        Price = other.Price;
      }
      if (other.BBuy != false) {
        BBuy = other.BBuy;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Despetion = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Price = input.ReadUInt32();
            break;
          }
          case 32: {
            BBuy = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// login -> client 302
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UpdateStoreItemAck : pb::IMessage<UpdateStoreItemAck> {
    private static readonly pb::MessageParser<UpdateStoreItemAck> _parser = new pb::MessageParser<UpdateStoreItemAck>(() => new UpdateStoreItemAck());
    public static pb::MessageParser<UpdateStoreItemAck> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Gamedef.StoreReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UpdateStoreItemAck() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UpdateStoreItemAck(UpdateStoreItemAck other) : this() {
      itemList_ = other.itemList_.Clone();
    }

    public UpdateStoreItemAck Clone() {
      return new UpdateStoreItemAck(this);
    }

    /// <summary>Field number for the "ItemList" field.</summary>
    public const int ItemListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Gamedef.Store_ItemInfo> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(10, global::Gamedef.Store_ItemInfo.Parser);
    private readonly pbc::RepeatedField<global::Gamedef.Store_ItemInfo> itemList_ = new pbc::RepeatedField<global::Gamedef.Store_ItemInfo>();
    public pbc::RepeatedField<global::Gamedef.Store_ItemInfo> ItemList {
      get { return itemList_; }
    }

    public override bool Equals(object other) {
      return Equals(other as UpdateStoreItemAck);
    }

    public bool Equals(UpdateStoreItemAck other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!itemList_.Equals(other.itemList_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= itemList_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      itemList_.WriteTo(output, _repeated_itemList_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      return size;
    }

    public void MergeFrom(UpdateStoreItemAck other) {
      if (other == null) {
        return;
      }
      itemList_.Add(other.itemList_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code