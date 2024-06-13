FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/AspnetBoilerPlateMvcTest1.Web.Host/AspnetBoilerPlateMvcTest1.Web.Host.csproj", "src/AspnetBoilerPlateMvcTest1.Web.Host/"]
COPY ["src/AspnetBoilerPlateMvcTest1.Web.Core/AspnetBoilerPlateMvcTest1.Web.Core.csproj", "src/AspnetBoilerPlateMvcTest1.Web.Core/"]
COPY ["src/AspnetBoilerPlateMvcTest1.Application/AspnetBoilerPlateMvcTest1.Application.csproj", "src/AspnetBoilerPlateMvcTest1.Application/"]
COPY ["src/AspnetBoilerPlateMvcTest1.Core/AspnetBoilerPlateMvcTest1.Core.csproj", "src/AspnetBoilerPlateMvcTest1.Core/"]
COPY ["src/AspnetBoilerPlateMvcTest1.EntityFrameworkCore/AspnetBoilerPlateMvcTest1.EntityFrameworkCore.csproj", "src/AspnetBoilerPlateMvcTest1.EntityFrameworkCore/"]
WORKDIR "/src/src/AspnetBoilerPlateMvcTest1.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/AspnetBoilerPlateMvcTest1.Web.Host", "src/AspnetBoilerPlateMvcTest1.Web.Host"]
COPY ["src/AspnetBoilerPlateMvcTest1.Web.Core", "src/AspnetBoilerPlateMvcTest1.Web.Core"]
COPY ["src/AspnetBoilerPlateMvcTest1.Application", "src/AspnetBoilerPlateMvcTest1.Application"]
COPY ["src/AspnetBoilerPlateMvcTest1.Core", "src/AspnetBoilerPlateMvcTest1.Core"]
COPY ["src/AspnetBoilerPlateMvcTest1.EntityFrameworkCore", "src/AspnetBoilerPlateMvcTest1.EntityFrameworkCore"]
WORKDIR "/src/src/AspnetBoilerPlateMvcTest1.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "AspnetBoilerPlateMvcTest1.Web.Host.dll"]
