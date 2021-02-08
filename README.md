*** Comendos configuração ***

--dotnet ef migrations add EstruturaInicial
--dotnet ef database update

--dotnet tool install -g dotnet-aspnet-codegenerator
-- dotnet aspnet-codegenerator controller -name ClientesController -m Cliente -dc
ContextoLoja1 --relativeFolderPath Controller --useDefaultLayout
--dotnet  aspnet-codegenerator controller -name ProdutosController -m Produto -dc

dotnet aspnet-codegenerator controller -name AdministradoresController -m Administrador -dc ContextoCms --
relativeFolderPath Controllers --useDefaultLayout