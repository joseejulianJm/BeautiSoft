#pragma checksum "C:\Users\57311\OneDrive\Escritorio\Asp .net\BeautiSoft\BeautiSoft.WEB\Views\Citas\ListarCitas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "655069259fc18dc71ba81cd6fe2afdfe741d802a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Citas_ListarCitas), @"mvc.1.0.view", @"/Views/Citas/ListarCitas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"655069259fc18dc71ba81cd6fe2afdfe741d802a", @"/Views/Citas/ListarCitas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c540bd3f39f7361201fe4d91e3fe8f567dcd29e", @"/Views/_ViewImports.cshtml")]
    public class Views_Citas_ListarCitas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<a");
            BeginWriteAttribute("onclick", " onclick=\"", 2, "\"", 103, 4);
            WriteAttributeValue("", 12, "mostrarModal(\'", 12, 14, true);
#nullable restore
#line 1 "C:\Users\57311\OneDrive\Escritorio\Asp .net\BeautiSoft\BeautiSoft.WEB\Views\Citas\ListarCitas.cshtml"
WriteAttributeValue("", 26, Url.Action("CrearCita","Citas",null,Context.Request.Scheme), 26, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 86, "\',\'Agendar", 86, 10, true);
            WriteAttributeValue(" ", 96, "Cita\')", 97, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-site mb-3\" style=\"color:white\">Agendar Cita </a>\r\n");
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
