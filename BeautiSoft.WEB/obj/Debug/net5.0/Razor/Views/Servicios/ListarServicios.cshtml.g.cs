#pragma checksum "C:\Users\57311\OneDrive\Escritorio\Asp .net\BeautiSoft\BeautiSoft.WEB\Views\Servicios\ListarServicios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c2c06604e8afb54f9ead85a2a99e68ee78be911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicios_ListarServicios), @"mvc.1.0.view", @"/Views/Servicios/ListarServicios.cshtml")]
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
#line 1 "C:\Users\57311\OneDrive\Escritorio\Asp .net\BeautiSoft\BeautiSoft.WEB\Views\_ViewImports.cshtml"
using BeautiSoft.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\57311\OneDrive\Escritorio\Asp .net\BeautiSoft\BeautiSoft.WEB\Views\_ViewImports.cshtml"
using BeautiSoft.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c2c06604e8afb54f9ead85a2a99e68ee78be911", @"/Views/Servicios/ListarServicios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c540bd3f39f7361201fe4d91e3fe8f567dcd29e", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicios_ListarServicios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/DataTable/tabla.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n    <div class=\"col mt-3\">\n        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 99, "\"", 214, 4);
            WriteAttributeValue("", 109, "mostrarModal(\'", 109, 14, true);
#nullable restore
#line 4 "C:\Users\57311\OneDrive\Escritorio\Asp .net\BeautiSoft\BeautiSoft.WEB\Views\Servicios\ListarServicios.cshtml"
WriteAttributeValue("", 123, Url.Action("CrearServicio","Servicios",null,Context.Request.Scheme), 123, 68, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 191, "\',\'Registrar", 191, 12, true);
            WriteAttributeValue(" ", 203, "Servicio\')", 204, 11, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn bg-site mb-3"" style=""color:white""> <i class=""fas fa-balance-scale  mr-2""></i>Registrar servicio </a>
        <table class=""table table-bordered table-striped table-hover"" id=""tabla"">
            <thead>
                <tr class=""text-center"">
                    <th scope=""col"">#</th>
                    <th scope=""col"">Servicio</th>
                    <th scope=""col"">Detalle</th>
                    <th scope=""col"">Estado</th>
                    <th scope=""col"">Acciones</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>5656</td>
                    <td>motilada</td>
                    <td>aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</td>
                    <td>Activo</td>
                    <td>
                        <div class=""d-flex justify-content-between"">
                            <i title=""Editar"" class=""far fa-edit text-warning""></i>
                            <i title=""Deshabilitar"" class=""fas fa-bell-");
            WriteLiteral("slash mr-2 text-danger\"></i>\n                            <i title=\"Detalle\" class=\"fas fa-book text-success\"></i>\n                        </div>\n                    </td>\n                </tr>\n");
            WriteLiteral("            </tbody>\n        </table>\n\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c2c06604e8afb54f9ead85a2a99e68ee78be9115789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n");
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
