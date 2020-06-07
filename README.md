Grpc 实例

dotnet core下实现Grpc服务主要以下步骤：

### 服务端

1. 定义proto文件
> 定义服务名、输入、输出

2. 使用Grpc.Tools，根据Proto文件生成Grpc服务基类代码

3. 暴露服务
> Add Grpc  
> Map Grpc

4. HTTPS协议

### 客户端

1. dotnet grpc add-file 引用Grpc服务

2. 注册，AddGrpcCLient


### 本实例下载运行步骤：

1. 启动Grpc.Service

2. 启动Grpc.Client

3. 浏览器输入Http://localhost:5000