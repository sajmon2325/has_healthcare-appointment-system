FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER root
RUN mkdir -p /https

WORKDIR /app
EXPOSE 5010
EXPOSE 5011

COPY ./certificates/Healthcare_Appointment_System.pfx /https/Healthcare_Appointment_System.pfx

ENV ASPNETCORE_Kestrel__Certificates__Default__Path=/https/Healthcare_Appointment_System.pfx

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Healthcare_Appointment_System.csproj", "./"]
RUN dotnet restore "Healthcare_Appointment_System.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "Healthcare_Appointment_System.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Healthcare_Appointment_System.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Healthcare_Appointment_System.dll"]
