// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/material.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Grpc.Service {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class material
  {
    static readonly string __ServiceName = "material.material";

    static readonly grpc::Marshaller<global::Grpc.Service.MaterialModel> __Marshaller_material_MaterialModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpc.Service.MaterialModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Grpc.Service.MaterialReturn> __Marshaller_material_MaterialReturn = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpc.Service.MaterialReturn.Parser.ParseFrom);

    static readonly grpc::Method<global::Grpc.Service.MaterialModel, global::Grpc.Service.MaterialReturn> __Method_Add = new grpc::Method<global::Grpc.Service.MaterialModel, global::Grpc.Service.MaterialReturn>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Add",
        __Marshaller_material_MaterialModel,
        __Marshaller_material_MaterialReturn);

    static readonly grpc::Method<global::Grpc.Service.MaterialModel, global::Grpc.Service.MaterialReturn> __Method_Reduce = new grpc::Method<global::Grpc.Service.MaterialModel, global::Grpc.Service.MaterialReturn>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Reduce",
        __Marshaller_material_MaterialModel,
        __Marshaller_material_MaterialReturn);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Grpc.Service.MaterialReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of material</summary>
    [grpc::BindServiceMethod(typeof(material), "BindService")]
    public abstract partial class materialBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Grpc.Service.MaterialReturn> Add(global::Grpc.Service.MaterialModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Grpc.Service.MaterialReturn> Reduce(global::Grpc.Service.MaterialModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(materialBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Add, serviceImpl.Add)
          .AddMethod(__Method_Reduce, serviceImpl.Reduce).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, materialBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Add, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Grpc.Service.MaterialModel, global::Grpc.Service.MaterialReturn>(serviceImpl.Add));
      serviceBinder.AddMethod(__Method_Reduce, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Grpc.Service.MaterialModel, global::Grpc.Service.MaterialReturn>(serviceImpl.Reduce));
    }

  }
}
#endregion