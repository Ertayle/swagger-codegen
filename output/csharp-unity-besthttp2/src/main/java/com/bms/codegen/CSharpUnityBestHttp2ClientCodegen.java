package com.bms.codegen;

import io.swagger.codegen.v3.*;
import io.swagger.codegen.v3.generators.DefaultCodegenConfig;

import java.io.File;
import java.util.*;

import static org.apache.commons.lang3.StringUtils.isEmpty;

public class CSharpUnityBestHttp2ClientCodegen extends DefaultCodegenConfig {
    @SuppressWarnings({"hiding"})
    
    // folders where to write the files
    protected String apiVersion = "1.0.0";
    protected String packageName = "UnityBestHttp2Client";
    protected String sourceFolder = "src/" + packageName;
    protected String clientPackageDir = sourceFolder + "/Client";
    protected String propertiesFolder = sourceFolder + "/Properties";
    protected String apiDocPath = "docs/";
    protected String modelDocPath = "docs/";

    /**
     * Configures the type of generator.
     * 
     * @return  the CodegenType for this generator
     * @see     io.swagger.codegen.CodegenType
     */
    public CodegenType getTag() {
    return CodegenType.CLIENT;
    }

    /**
     * Configures a friendly name for the generator.  This will be used by the generator
     * to select the library with the -l flag.
     * 
     * @return the friendly name for the generator
     */
    public String getName() {
    return "csharp-unity-besthttp2";
    }

    /**
     * Returns human-friendly help for the generator.  Provide the consumer with help
     * tips, parameters here
     * 
     * @return A string value for the help message
     */
    public String getHelp() {
    return "Generates a csharp-unity-besthttp2 client library.";
    }

    public CSharpUnityBestHttp2ClientCodegen() {
        super();

        /**
         * Template Location.  This is the location which templates will be read from.  The generator
         * will use the resource stream to attempt to read the templates.
         */
        templateDir = "csharp-unity-besthttp2";

        /**
         * Api Package.  Optional, if needed, this can be used in templates
         */
        apiPackage = "Api";

        /**
         * Model Package.  Optional, if needed, this can be used in templates
         */
        modelPackage = "Model";

        supportsInheritance = true;

        modelTemplateFiles.put("model.mustache", ".cs");
        apiTemplateFiles.put("api.mustache", ".cs");

        modelDocTemplateFiles.put("model_doc.mustache", ".md");
        apiDocTemplateFiles.put("api_doc.mustache", ".md");

        hideGenerationTimestamp = Boolean.TRUE;

        /**
         * Additional Properties.  These values can be passed to the templates and
         * are available in models, apis, and supporting files
         */
        additionalProperties.put("apiVersion", apiVersion);
        additionalProperties.put("packageName", packageName);
        additionalProperties.put("apiDocPath", apiDocPath);
        additionalProperties.put("modelDocPath", modelDocPath);


        /**
         * Supporting Files.  You can write single files for the generator with the
         * entire object tree available.  If the input file has a suffix of `.mustache
         * it will be processed by the template engine.  Otherwise, it will be copied
         */
        supportingFiles.add(new SupportingFile("IApiAccessor.mustache",
                clientPackageDir, "IApiAccessor.cs"));
        supportingFiles.add(new SupportingFile("Configuration.mustache",
                clientPackageDir, "Configuration.cs"));
        supportingFiles.add(new SupportingFile("ApiClient.mustache",
                clientPackageDir, "ApiClient.cs"));
        supportingFiles.add(new SupportingFile("ApiException.mustache",
                clientPackageDir, "ApiException.cs"));
        supportingFiles.add(new SupportingFile("ApiResponse.mustache",
                clientPackageDir, "ApiResponse.cs"));
        supportingFiles.add(new SupportingFile("ExceptionFactory.mustache",
                clientPackageDir, "ExceptionFactory.cs"));
        supportingFiles.add(new SupportingFile("SwaggerDateConverter.mustache",
                clientPackageDir, "SwaggerDateConverter.cs"));
        supportingFiles.add(new SupportingFile("IReadableConfiguration.mustache",
                clientPackageDir, "IReadableConfiguration.cs"));
        supportingFiles.add(new SupportingFile("GlobalConfiguration.mustache",
                clientPackageDir, "GlobalConfiguration.cs"));                


        supportingFiles.add(new SupportingFile("README.mustache", "", "README.md"));
        supportingFiles.add(new SupportingFile("git_push.sh.mustache", "", "git_push.sh"));
        supportingFiles.add(new SupportingFile("gitignore.mustache", "", ".gitignore"));

        /**
         * C# Specific Primitives.  These types will not trigger imports by
         * the client generator
         */
        languageSpecificPrimitives = new HashSet<String>(
        Arrays.asList(
            "void",
            "int",
            "char",
            "double",
            "float")
        );
        
        /**
         * Reserved C# words.
         */
        reservedWords = new HashSet<String> (
        Arrays.asList(
            "abstract",
            "As",
            "base",
            "bool",
            "break",
            "byte",
            "case",
            "catch",
            "Char",
            "checked",
            "class",
            "const",
            "continue",
            "decimal",
            "default",
            "delegate",
            "do",
            "double",
            "else",
            "enum",
            "event",
            "explicit",
            "Extern",
            "false",
            "finally",
            "fixed",
            "float",
            "for",
            "foreach",
            "Goto",
            "if",
            "implicit",
            "in",
            "int",
            "interface",
            "internal",
            "is",
            "lock",
            "long",
            "namespace",
            "new",
            "null",
            "Object",
            "operator",
            "out",
            "override",
            "params",
            "private",
            "protected",
            "public",
            "readonly",
            "ref",
            "return",
            "sbyte",
            "sealed",
            "Short",
            "sizeof",
            "stackalloc",
            "static",
            "string",
            "struct",
            "switch",
            "This",
            "throw",
            "true",
            "try",
            "typeof",
            "uint",
            "ulong",
            "unchecked",
            "unsafe",
            "ushort",
            "using",
            "virtual",
            "void",
            "volatile",
            "While")
        );
    }

    public String modelFileFolder() {
        return outputFolder + "/" + sourceFolder + "/" + modelPackage().replace('.', File.separatorChar);
    }

    @Override
    public String apiFileFolder() {
        return outputFolder + "/" + sourceFolder + "/" + apiPackage().replace('.', File.separatorChar);
    }

    @Override
    public String apiDocFileFolder() {
        return (outputFolder + "/" + apiDocPath).replace('/', File.separatorChar);
    }

    @Override
    public String modelDocFileFolder() {
        return (outputFolder + "/" + modelDocPath).replace('/', File.separatorChar);
    }

    @Override
    public String getArgumentsLocation() {
        return null;
    }

    @Override
    protected String getTemplateDir() {
        return templateDir;
    }

    @Override
    public String getDefaultTemplateDir() {
        return templateDir;
    }

    @Override
    public String escapeReservedWord(String input) {
        // just return the original string
        return input;
    }

    @Override
    public String escapeQuotationMark(String input) {
        // just return the original string
        return input;
    }

    @Override
    public String escapeUnsafeCharacters(String input) {
        // just return the original string
        return input;
    }    
}
