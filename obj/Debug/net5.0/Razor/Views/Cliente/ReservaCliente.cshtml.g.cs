#pragma checksum "G:\UNIVERSIDAD SAN MARTIN DE PORRES\2021-I\PROGRAMACION I\LABORATORIO\PROYECTOS\NARANJA\Views\Cliente\ReservaCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33df52e5cbfc5c940c06c2d6a798bce5b53bd2e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_ReservaCliente), @"mvc.1.0.view", @"/Views/Cliente/ReservaCliente.cshtml")]
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
#line 1 "G:\UNIVERSIDAD SAN MARTIN DE PORRES\2021-I\PROGRAMACION I\LABORATORIO\PROYECTOS\NARANJA\Views\_ViewImports.cshtml"
using NARANJA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\UNIVERSIDAD SAN MARTIN DE PORRES\2021-I\PROGRAMACION I\LABORATORIO\PROYECTOS\NARANJA\Views\_ViewImports.cshtml"
using NARANJA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33df52e5cbfc5c940c06c2d6a798bce5b53bd2e8", @"/Views/Cliente/ReservaCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04f2064ae81ce91a21a8bf46d9a57a003381edf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_ReservaCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\UNIVERSIDAD SAN MARTIN DE PORRES\2021-I\PROGRAMACION I\LABORATORIO\PROYECTOS\NARANJA\Views\Cliente\ReservaCliente.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout="_LayoutCliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\" >RESERVAS</h1>\r\n<hr width=\"400\" size=\"15\" noshade=\"noshade\">\r\n\r\n<br>\r\n<br>\r\n\r\n<div>\r\n    <h3>Nombres</h3>\r\n     <input class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 252, "\"", 266, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n\r\n<br>\r\n<br>\r\n\r\n<div>\r\n    <h3>Apellidos</h3>\r\n     <input class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 369, "\"", 383, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n\r\n<br>\r\n<br>\r\n\r\n<div>\r\n    <h3>Fecha</h3>\r\n    <input class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 481, "\"", 495, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n\r\n<br>\r\n<br>\r\n\r\n<div>\r\n    <h3>Numero de Personas</h3>\r\n     <input class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 607, "\"", 621, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n\r\n<br>\r\n\r\n<div>\r\n<button type=\"button\" class=\"btn btn-success center\">RESERVAR</button>\r\n</div>");
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
