// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcService;

Console.WriteLine("Hello, World!");

var channel = GrpcChannel.ForAddress("https://localhost:7279");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
    new HelloRequest { Name = "我是客户端" });
Console.WriteLine("Greeter 服务返回数据: " + reply.Message);
Console.ReadKey();
