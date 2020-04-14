# Entity Framework

# Ajouter la dependance "entity framework" et "entity Framework inMemory" au projet

````bash
PS C:\PERSONNEL\dot_net_training\test3> dotnet add package Microsoft.EntityFrameworkCore
PS C:\PERSONNEL\dot_net_training\test3> dotnet add package Microsoft.EntityFrameworkCore.InMemory
````


voir le fichier  projet .csproj qu'ils soient bien integré au projet
````xml
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="3.1.3" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.InMemory" Version="3.1.3" />       
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="1.1.0-msbuild3-final">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
  </ItemGroup>

</Project>

````

## importer la librairie **entity framework** pour etre utilser.

la primary clé se base soit sur le nom de la variable de 'entité' devant contenir à la fin la chaine **Id** soit défint une annotation **[key]**