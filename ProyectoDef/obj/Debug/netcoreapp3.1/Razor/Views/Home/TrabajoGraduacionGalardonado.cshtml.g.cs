#pragma checksum "C:\Users\marib\Downloads\New WinRAR ZIP archive (1)\ProyectoDef\Views\Home\TrabajoGraduacionGalardonado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90ff0e0cf135e86059e33667c4b388535d2ebb06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TrabajoGraduacionGalardonado), @"mvc.1.0.view", @"/Views/Home/TrabajoGraduacionGalardonado.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\marib\Downloads\New WinRAR ZIP archive (1)\ProyectoDef\Views\_ViewImports.cshtml"
using ProyectoDef;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marib\Downloads\New WinRAR ZIP archive (1)\ProyectoDef\Views\_ViewImports.cshtml"
using ProyectoDef.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ff0e0cf135e86059e33667c4b388535d2ebb06", @"/Views/Home/TrabajoGraduacionGalardonado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff8871d0eca8f052be3ebb087e3205038047cc95", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TrabajoGraduacionGalardonado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\marib\Downloads\New WinRAR ZIP archive (1)\ProyectoDef\Views\Home\TrabajoGraduacionGalardonado.cshtml"
  
    ViewData["Title"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\marib\Downloads\New WinRAR ZIP archive (1)\ProyectoDef\Views\Home\TrabajoGraduacionGalardonado.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>



<div class=""content-container"">

    <div class=""container-fluid"">

        <!-- Main component for a primary marketing message or call to action -->
        <div class=""jumbotron"">
            <h1>Trabajo de Graduación Galardonado</h1>
            <br />

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90ff0e0cf135e86059e33667c4b388535d2ebb064129", async() => {
                WriteLiteral("\r\n                <div class=\"form-row\">\r\n                    <div class=\"form-group col-md-10\">\r\n");
                WriteLiteral("                        <input type=\"text\" class=\"form-control\" id=\"inputFunc\" placeholder=\"Nombre del Proyecto de Graduación Galardonado\">\r\n                    </div>\r\n                    <div class=\"form-group col-md-10\">\r\n");
                WriteLiteral(@"                        <input type=""text"" class=""form-control"" id=""inputCed"" placeholder=""Certificación de la Institución"">
                    </div>

                </div>

                <p class=""text-info"">Cargar archivo:</p>
                <div class=""form-group mt-3"">
                    <input type=""file"" name=""file"">
                </div>


                <button type=""submit"" class=""btn btn-info"">Agregar otro trabajo</button>
                <button type=""submit"" class=""btn btn-primary"">Aceptar</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
