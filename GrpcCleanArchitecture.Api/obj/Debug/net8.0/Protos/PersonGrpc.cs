// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Person.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcCleanArchitecture.Proto {
  public static partial class PersonService
  {
    static readonly string __ServiceName = "PersonService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcCleanArchitecture.Proto.CreatePersonRequest> __Marshaller_CreatePersonRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcCleanArchitecture.Proto.CreatePersonRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcCleanArchitecture.Proto.PersonResponse> __Marshaller_PersonResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcCleanArchitecture.Proto.PersonResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcCleanArchitecture.Proto.PersonByIdRequest> __Marshaller_PersonByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcCleanArchitecture.Proto.PersonByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcCleanArchitecture.Proto.UpdatePersonRequest> __Marshaller_UpdatePersonRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcCleanArchitecture.Proto.UpdatePersonRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcCleanArchitecture.Proto.DeletePersonResponse> __Marshaller_DeletePersonResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcCleanArchitecture.Proto.DeletePersonResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcCleanArchitecture.Proto.CreatePersonRequest, global::GrpcCleanArchitecture.Proto.PersonResponse> __Method_CreatePerson = new grpc::Method<global::GrpcCleanArchitecture.Proto.CreatePersonRequest, global::GrpcCleanArchitecture.Proto.PersonResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreatePerson",
        __Marshaller_CreatePersonRequest,
        __Marshaller_PersonResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcCleanArchitecture.Proto.PersonByIdRequest, global::GrpcCleanArchitecture.Proto.PersonResponse> __Method_GetPersonById = new grpc::Method<global::GrpcCleanArchitecture.Proto.PersonByIdRequest, global::GrpcCleanArchitecture.Proto.PersonResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPersonById",
        __Marshaller_PersonByIdRequest,
        __Marshaller_PersonResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcCleanArchitecture.Proto.UpdatePersonRequest, global::GrpcCleanArchitecture.Proto.PersonResponse> __Method_UpdatePerson = new grpc::Method<global::GrpcCleanArchitecture.Proto.UpdatePersonRequest, global::GrpcCleanArchitecture.Proto.PersonResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePerson",
        __Marshaller_UpdatePersonRequest,
        __Marshaller_PersonResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcCleanArchitecture.Proto.PersonByIdRequest, global::GrpcCleanArchitecture.Proto.DeletePersonResponse> __Method_DeletePerson = new grpc::Method<global::GrpcCleanArchitecture.Proto.PersonByIdRequest, global::GrpcCleanArchitecture.Proto.DeletePersonResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePerson",
        __Marshaller_PersonByIdRequest,
        __Marshaller_DeletePersonResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcCleanArchitecture.Proto.PersonReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PersonService</summary>
    [grpc::BindServiceMethod(typeof(PersonService), "BindService")]
    public abstract partial class PersonServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcCleanArchitecture.Proto.PersonResponse> CreatePerson(global::GrpcCleanArchitecture.Proto.CreatePersonRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcCleanArchitecture.Proto.PersonResponse> GetPersonById(global::GrpcCleanArchitecture.Proto.PersonByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcCleanArchitecture.Proto.PersonResponse> UpdatePerson(global::GrpcCleanArchitecture.Proto.UpdatePersonRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcCleanArchitecture.Proto.DeletePersonResponse> DeletePerson(global::GrpcCleanArchitecture.Proto.PersonByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PersonServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreatePerson, serviceImpl.CreatePerson)
          .AddMethod(__Method_GetPersonById, serviceImpl.GetPersonById)
          .AddMethod(__Method_UpdatePerson, serviceImpl.UpdatePerson)
          .AddMethod(__Method_DeletePerson, serviceImpl.DeletePerson).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PersonServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreatePerson, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcCleanArchitecture.Proto.CreatePersonRequest, global::GrpcCleanArchitecture.Proto.PersonResponse>(serviceImpl.CreatePerson));
      serviceBinder.AddMethod(__Method_GetPersonById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcCleanArchitecture.Proto.PersonByIdRequest, global::GrpcCleanArchitecture.Proto.PersonResponse>(serviceImpl.GetPersonById));
      serviceBinder.AddMethod(__Method_UpdatePerson, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcCleanArchitecture.Proto.UpdatePersonRequest, global::GrpcCleanArchitecture.Proto.PersonResponse>(serviceImpl.UpdatePerson));
      serviceBinder.AddMethod(__Method_DeletePerson, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcCleanArchitecture.Proto.PersonByIdRequest, global::GrpcCleanArchitecture.Proto.DeletePersonResponse>(serviceImpl.DeletePerson));
    }

  }
}
#endregion
