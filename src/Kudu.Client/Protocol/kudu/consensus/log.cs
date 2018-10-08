// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: log.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace Kudu.Client.Protocol.Log
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LogEntryPB : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public LogEntryTypePB Type { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"replicate")]
        public global::Kudu.Client.Protocol.Consensus.ReplicateMsg Replicate { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"commit")]
        public global::Kudu.Client.Protocol.Consensus.CommitMsg Commit { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LogEntryBatchPB : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"entry")]
        public global::System.Collections.Generic.List<LogEntryPB> Entries { get; } = new global::System.Collections.Generic.List<LogEntryPB>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LogSegmentHeaderPB : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"DEPRECATED_major_version")]
        public uint DEPRECATEDmajorversion
        {
            get { return __pbn__DEPRECATEDmajorversion.GetValueOrDefault(); }
            set { __pbn__DEPRECATEDmajorversion = value; }
        }
        public bool ShouldSerializeDEPRECATEDmajorversion() => __pbn__DEPRECATEDmajorversion != null;
        public void ResetDEPRECATEDmajorversion() => __pbn__DEPRECATEDmajorversion = null;
        private uint? __pbn__DEPRECATEDmajorversion;

        [global::ProtoBuf.ProtoMember(2, Name = @"DEPRECATED_minor_version")]
        public uint DEPRECATEDminorversion
        {
            get { return __pbn__DEPRECATEDminorversion.GetValueOrDefault(); }
            set { __pbn__DEPRECATEDminorversion = value; }
        }
        public bool ShouldSerializeDEPRECATEDminorversion() => __pbn__DEPRECATEDminorversion != null;
        public void ResetDEPRECATEDminorversion() => __pbn__DEPRECATEDminorversion = null;
        private uint? __pbn__DEPRECATEDminorversion;

        [global::ProtoBuf.ProtoMember(10, Name = @"incompatible_features")]
        public int[] IncompatibleFeatures { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"tablet_id", IsRequired = true)]
        public byte[] TabletId { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"sequence_number", IsRequired = true)]
        public ulong SequenceNumber { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"schema", IsRequired = true)]
        public global::Kudu.Client.Protocol.SchemaPB Schema { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"schema_version")]
        public uint SchemaVersion
        {
            get { return __pbn__SchemaVersion.GetValueOrDefault(); }
            set { __pbn__SchemaVersion = value; }
        }
        public bool ShouldSerializeSchemaVersion() => __pbn__SchemaVersion != null;
        public void ResetSchemaVersion() => __pbn__SchemaVersion = null;
        private uint? __pbn__SchemaVersion;

        [global::ProtoBuf.ProtoMember(9, Name = @"compression_codec")]
        [global::System.ComponentModel.DefaultValue(global::Kudu.Client.Protocol.CompressionTypePB.NoCompression)]
        public global::Kudu.Client.Protocol.CompressionTypePB CompressionCodec
        {
            get { return __pbn__CompressionCodec ?? global::Kudu.Client.Protocol.CompressionTypePB.NoCompression; }
            set { __pbn__CompressionCodec = value; }
        }
        public bool ShouldSerializeCompressionCodec() => __pbn__CompressionCodec != null;
        public void ResetCompressionCodec() => __pbn__CompressionCodec = null;
        private global::Kudu.Client.Protocol.CompressionTypePB? __pbn__CompressionCodec;

        [global::ProtoBuf.ProtoContract()]
        public enum FeatureFlag
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 999,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LogSegmentFooterPB : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"num_entries", IsRequired = true)]
        public long NumEntries { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"min_replicate_index")]
        [global::System.ComponentModel.DefaultValue(-1)]
        public long MinReplicateIndex
        {
            get { return __pbn__MinReplicateIndex ?? -1; }
            set { __pbn__MinReplicateIndex = value; }
        }
        public bool ShouldSerializeMinReplicateIndex() => __pbn__MinReplicateIndex != null;
        public void ResetMinReplicateIndex() => __pbn__MinReplicateIndex = null;
        private long? __pbn__MinReplicateIndex;

        [global::ProtoBuf.ProtoMember(3, Name = @"max_replicate_index")]
        [global::System.ComponentModel.DefaultValue(-1)]
        public long MaxReplicateIndex
        {
            get { return __pbn__MaxReplicateIndex ?? -1; }
            set { __pbn__MaxReplicateIndex = value; }
        }
        public bool ShouldSerializeMaxReplicateIndex() => __pbn__MaxReplicateIndex != null;
        public void ResetMaxReplicateIndex() => __pbn__MaxReplicateIndex = null;
        private long? __pbn__MaxReplicateIndex;

        [global::ProtoBuf.ProtoMember(4, Name = @"close_timestamp_micros")]
        public long CloseTimestampMicros
        {
            get { return __pbn__CloseTimestampMicros.GetValueOrDefault(); }
            set { __pbn__CloseTimestampMicros = value; }
        }
        public bool ShouldSerializeCloseTimestampMicros() => __pbn__CloseTimestampMicros != null;
        public void ResetCloseTimestampMicros() => __pbn__CloseTimestampMicros = null;
        private long? __pbn__CloseTimestampMicros;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum LogEntryTypePB
    {
        [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
        Unknown = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"REPLICATE")]
        Replicate = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"COMMIT")]
        Commit = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"FLUSH_MARKER")]
        FlushMarker = 999,
    }

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
