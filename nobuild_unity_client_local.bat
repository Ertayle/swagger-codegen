java -cp output/csharp-unity-besthttp2/target/csharp-unity-besthttp2-swagger-codegen-1.0.0.jar;modules/swagger-codegen-cli/target/swagger-codegen-cli.jar ^
	io.swagger.codegen.v3.cli.SwaggerCodegen generate ^
	-i http://localhost:3000/api-json/                ^
	-c swagger-codegen_config.json                    ^
	-o unity_client_local                     ^
	-l csharp-unity-besthttp2
:: cd "%~dp0\unity_client_local"
:: "%~dp0\unity_client_local\build.bat"