#pragma checksum "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a0987e7b0b97e01f9dd18c4e85cf70db41a351f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solicitud_Listar), @"mvc.1.0.view", @"/Views/Solicitud/Listar.cshtml")]
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
#line 1 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\_ViewImports.cshtml"
using Practica03;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\_ViewImports.cshtml"
using Practica03.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a0987e7b0b97e01f9dd18c4e85cf70db41a351f", @"/Views/Solicitud/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"237add5cb4226598f1aae2f1f54470c6e0a9321b", @"/Views/_ViewImports.cshtml")]
    public class Views_Solicitud_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Solicitud>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
  
    Layout="_Plantilla";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Lista de Usuarios</h1>\r\n    \r\n\r\n");
#nullable restore
#line 11 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
     if (Model.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No hay usuarios registrados aun</p>\r\n");
#nullable restore
#line 13 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    \r\n\r\n");
#nullable restore
#line 17 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n  <div class=\"container\">\r\n    <h1>");
#nullable restore
#line 19 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n      <div class=\"col\">\r\n        <div id=\"products\" class=\"mb-3\">\r\n          <div class=\"row\">\r\n");
#nullable restore
#line 24 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-4\">\r\n              <div class=\"card mb-3\">\r\n                <div class=\"card-body\">\r\n                  <div class=\"card-img-actions\">\r\n                    <img class=\"img-responsive\" width=\"96\" height=\"150\"");
            BeginWriteAttribute("src", "\r\n                       src=\"", 736, "\"", 776, 1);
#nullable restore
#line 30 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
WriteAttributeValue("", 766, item.Foto, 766, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Icono\"  />\r\n                  </div>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                  <h5 class=\"card-title\">");
#nullable restore
#line 34 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 35 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 36 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 37 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 38 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Lugar));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 39 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 40 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.categoria.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  \r\n                </div>\r\n              </div>\r\n            </div>\r\n");
#nullable restore
#line 45 "F:\usmp\sexto ciclo\Progra I\Lab\Clases\usmp\programacion 1\Practica03\Views\Solicitud\Listar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("         </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Solicitud>> Html { get; private set; }
    }
}
#pragma warning restore 1591