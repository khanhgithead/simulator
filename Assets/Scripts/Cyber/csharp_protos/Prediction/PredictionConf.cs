// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/prediction/proto/prediction_conf.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Prediction {

  /// <summary>Holder for reflection information generated from modules/prediction/proto/prediction_conf.proto</summary>
  public static partial class PredictionConfReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/prediction/proto/prediction_conf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PredictionConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5tb2R1bGVzL3ByZWRpY3Rpb24vcHJvdG8vcHJlZGljdGlvbl9jb25mLnBy",
            "b3RvEhFhcG9sbG8ucHJlZGljdGlvbhoybW9kdWxlcy9wZXJjZXB0aW9uL3By",
            "b3RvL3BlcmNlcHRpb25fb2JzdGFjbGUucHJvdG8ihwYKDE9ic3RhY2xlQ29u",
            "ZhJBCg1vYnN0YWNsZV90eXBlGAEgASgOMiouYXBvbGxvLnBlcmNlcHRpb24u",
            "UGVyY2VwdGlvbk9ic3RhY2xlLlR5cGUSRwoPb2JzdGFjbGVfc3RhdHVzGAIg",
            "ASgOMi4uYXBvbGxvLnByZWRpY3Rpb24uT2JzdGFjbGVDb25mLk9ic3RhY2xl",
            "U3RhdHVzEkUKDmV2YWx1YXRvcl90eXBlGAMgASgOMi0uYXBvbGxvLnByZWRp",
            "Y3Rpb24uT2JzdGFjbGVDb25mLkV2YWx1YXRvclR5cGUSRQoOcHJlZGljdG9y",
            "X3R5cGUYBCABKA4yLS5hcG9sbG8ucHJlZGljdGlvbi5PYnN0YWNsZUNvbmYu",
            "UHJlZGljdG9yVHlwZSJYCg5PYnN0YWNsZVN0YXR1cxILCgdPTl9MQU5FEAAS",
            "DAoIT0ZGX0xBTkUQARIOCgpTVEFUSU9OQVJZEAMSCgoGTU9WSU5HEAQSDwoL",
            "SU5fSlVOQ1RJT04QBSK9AQoNRXZhbHVhdG9yVHlwZRIRCg1NTFBfRVZBTFVB",
            "VE9SEAASEQoNUk5OX0VWQUxVQVRPUhABEhIKDkNPU1RfRVZBTFVBVE9SEAIS",
            "GAoUQ1JVSVNFX01MUF9FVkFMVUFUT1IQAxIaChZKVU5DVElPTl9NTFBfRVZB",
            "TFVBVE9SEAQSHwobQ1lDTElTVF9LRUVQX0xBTkVfRVZBTFVBVE9SEAUSGwoX",
            "TEFORV9TQ0FOTklOR19FVkFMVUFUT1IQBiLCAQoNUHJlZGljdG9yVHlwZRIb",
            "ChdMQU5FX1NFUVVFTkNFX1BSRURJQ1RPUhAAEhcKE0ZSRUVfTU9WRV9QUkVE",
            "SUNUT1IQARIWChJSRUdJT05BTF9QUkVESUNUT1IQAhIbChdNT1ZFX1NFUVVF",
            "TkNFX1BSRURJQ1RPUhADEhMKD0VNUFRZX1BSRURJQ1RPUhAEEhkKFVNJTkdM",
            "RV9MQU5FX1BSRURJQ1RPUhAFEhYKEkpVTkNUSU9OX1BSRURJQ1RPUhAGIkgK",
            "DlByZWRpY3Rpb25Db25mEjYKDW9ic3RhY2xlX2NvbmYYASADKAsyHy5hcG9s",
            "bG8ucHJlZGljdGlvbi5PYnN0YWNsZUNvbmZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Perception.PerceptionObstacleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Prediction.ObstacleConf), global::Apollo.Prediction.ObstacleConf.Parser, new[]{ "ObstacleType", "ObstacleStatus", "EvaluatorType", "PredictorType" }, null, new[]{ typeof(global::Apollo.Prediction.ObstacleConf.Types.ObstacleStatus), typeof(global::Apollo.Prediction.ObstacleConf.Types.EvaluatorType), typeof(global::Apollo.Prediction.ObstacleConf.Types.PredictorType) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Prediction.PredictionConf), global::Apollo.Prediction.PredictionConf.Parser, new[]{ "ObstacleConf" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ObstacleConf : pb::IMessage<ObstacleConf> {
    private static readonly pb::MessageParser<ObstacleConf> _parser = new pb::MessageParser<ObstacleConf>(() => new ObstacleConf());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ObstacleConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Prediction.PredictionConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObstacleConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObstacleConf(ObstacleConf other) : this() {
      obstacleType_ = other.obstacleType_;
      obstacleStatus_ = other.obstacleStatus_;
      evaluatorType_ = other.evaluatorType_;
      predictorType_ = other.predictorType_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObstacleConf Clone() {
      return new ObstacleConf(this);
    }

    /// <summary>Field number for the "obstacle_type" field.</summary>
    public const int ObstacleTypeFieldNumber = 1;
    private global::Apollo.Perception.PerceptionObstacle.Types.Type obstacleType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Perception.PerceptionObstacle.Types.Type ObstacleType {
      get { return obstacleType_; }
      set {
        obstacleType_ = value;
      }
    }

    /// <summary>Field number for the "obstacle_status" field.</summary>
    public const int ObstacleStatusFieldNumber = 2;
    private global::Apollo.Prediction.ObstacleConf.Types.ObstacleStatus obstacleStatus_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Prediction.ObstacleConf.Types.ObstacleStatus ObstacleStatus {
      get { return obstacleStatus_; }
      set {
        obstacleStatus_ = value;
      }
    }

    /// <summary>Field number for the "evaluator_type" field.</summary>
    public const int EvaluatorTypeFieldNumber = 3;
    private global::Apollo.Prediction.ObstacleConf.Types.EvaluatorType evaluatorType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Prediction.ObstacleConf.Types.EvaluatorType EvaluatorType {
      get { return evaluatorType_; }
      set {
        evaluatorType_ = value;
      }
    }

    /// <summary>Field number for the "predictor_type" field.</summary>
    public const int PredictorTypeFieldNumber = 4;
    private global::Apollo.Prediction.ObstacleConf.Types.PredictorType predictorType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Prediction.ObstacleConf.Types.PredictorType PredictorType {
      get { return predictorType_; }
      set {
        predictorType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ObstacleConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ObstacleConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ObstacleType != other.ObstacleType) return false;
      if (ObstacleStatus != other.ObstacleStatus) return false;
      if (EvaluatorType != other.EvaluatorType) return false;
      if (PredictorType != other.PredictorType) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ObstacleType != 0) hash ^= ObstacleType.GetHashCode();
      if (ObstacleStatus != 0) hash ^= ObstacleStatus.GetHashCode();
      if (EvaluatorType != 0) hash ^= EvaluatorType.GetHashCode();
      if (PredictorType != 0) hash ^= PredictorType.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ObstacleType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ObstacleType);
      }
      if (ObstacleStatus != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ObstacleStatus);
      }
      if (EvaluatorType != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) EvaluatorType);
      }
      if (PredictorType != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) PredictorType);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ObstacleType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ObstacleType);
      }
      if (ObstacleStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ObstacleStatus);
      }
      if (EvaluatorType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EvaluatorType);
      }
      if (PredictorType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PredictorType);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ObstacleConf other) {
      if (other == null) {
        return;
      }
      if (other.ObstacleType != 0) {
        ObstacleType = other.ObstacleType;
      }
      if (other.ObstacleStatus != 0) {
        ObstacleStatus = other.ObstacleStatus;
      }
      if (other.EvaluatorType != 0) {
        EvaluatorType = other.EvaluatorType;
      }
      if (other.PredictorType != 0) {
        PredictorType = other.PredictorType;
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
            obstacleType_ = (global::Apollo.Perception.PerceptionObstacle.Types.Type) input.ReadEnum();
            break;
          }
          case 16: {
            obstacleStatus_ = (global::Apollo.Prediction.ObstacleConf.Types.ObstacleStatus) input.ReadEnum();
            break;
          }
          case 24: {
            evaluatorType_ = (global::Apollo.Prediction.ObstacleConf.Types.EvaluatorType) input.ReadEnum();
            break;
          }
          case 32: {
            predictorType_ = (global::Apollo.Prediction.ObstacleConf.Types.PredictorType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ObstacleConf message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum ObstacleStatus {
        [pbr::OriginalName("ON_LANE")] OnLane = 0,
        [pbr::OriginalName("OFF_LANE")] OffLane = 1,
        [pbr::OriginalName("STATIONARY")] Stationary = 3,
        [pbr::OriginalName("MOVING")] Moving = 4,
        [pbr::OriginalName("IN_JUNCTION")] InJunction = 5,
      }

      public enum EvaluatorType {
        [pbr::OriginalName("MLP_EVALUATOR")] MlpEvaluator = 0,
        [pbr::OriginalName("RNN_EVALUATOR")] RnnEvaluator = 1,
        /// <summary>
        /// navi mode can only support this evaluator
        /// </summary>
        [pbr::OriginalName("COST_EVALUATOR")] CostEvaluator = 2,
        [pbr::OriginalName("CRUISE_MLP_EVALUATOR")] CruiseMlpEvaluator = 3,
        [pbr::OriginalName("JUNCTION_MLP_EVALUATOR")] JunctionMlpEvaluator = 4,
        [pbr::OriginalName("CYCLIST_KEEP_LANE_EVALUATOR")] CyclistKeepLaneEvaluator = 5,
        [pbr::OriginalName("LANE_SCANNING_EVALUATOR")] LaneScanningEvaluator = 6,
      }

      public enum PredictorType {
        [pbr::OriginalName("LANE_SEQUENCE_PREDICTOR")] LaneSequencePredictor = 0,
        [pbr::OriginalName("FREE_MOVE_PREDICTOR")] FreeMovePredictor = 1,
        [pbr::OriginalName("REGIONAL_PREDICTOR")] RegionalPredictor = 2,
        [pbr::OriginalName("MOVE_SEQUENCE_PREDICTOR")] MoveSequencePredictor = 3,
        [pbr::OriginalName("EMPTY_PREDICTOR")] EmptyPredictor = 4,
        [pbr::OriginalName("SINGLE_LANE_PREDICTOR")] SingleLanePredictor = 5,
        [pbr::OriginalName("JUNCTION_PREDICTOR")] JunctionPredictor = 6,
      }

    }
    #endregion

  }

  public sealed partial class PredictionConf : pb::IMessage<PredictionConf> {
    private static readonly pb::MessageParser<PredictionConf> _parser = new pb::MessageParser<PredictionConf>(() => new PredictionConf());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PredictionConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Prediction.PredictionConfReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictionConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictionConf(PredictionConf other) : this() {
      obstacleConf_ = other.obstacleConf_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictionConf Clone() {
      return new PredictionConf(this);
    }

    /// <summary>Field number for the "obstacle_conf" field.</summary>
    public const int ObstacleConfFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Apollo.Prediction.ObstacleConf> _repeated_obstacleConf_codec
        = pb::FieldCodec.ForMessage(10, global::Apollo.Prediction.ObstacleConf.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Prediction.ObstacleConf> obstacleConf_ = new pbc::RepeatedField<global::Apollo.Prediction.ObstacleConf>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Prediction.ObstacleConf> ObstacleConf {
      get { return obstacleConf_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PredictionConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PredictionConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!obstacleConf_.Equals(other.obstacleConf_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= obstacleConf_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      obstacleConf_.WriteTo(output, _repeated_obstacleConf_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += obstacleConf_.CalculateSize(_repeated_obstacleConf_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PredictionConf other) {
      if (other == null) {
        return;
      }
      obstacleConf_.Add(other.obstacleConf_);
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
            obstacleConf_.AddEntriesFrom(input, _repeated_obstacleConf_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
