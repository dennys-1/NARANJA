#pragma checksum "D:\USMP-2021-1\pro lab\proyectoahorasi\Main\NARANJA\Views\Cliente\BoletaCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e45f8702b654ca20726e52710aaef487a430836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_BoletaCliente), @"mvc.1.0.view", @"/Views/Cliente/BoletaCliente.cshtml")]
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
#line 1 "D:\USMP-2021-1\pro lab\proyectoahorasi\Main\NARANJA\Views\_ViewImports.cshtml"
using NARANJA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\USMP-2021-1\pro lab\proyectoahorasi\Main\NARANJA\Views\_ViewImports.cshtml"
using NARANJA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e45f8702b654ca20726e52710aaef487a430836", @"/Views/Cliente/BoletaCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04f2064ae81ce91a21a8bf46d9a57a003381edf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_BoletaCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\USMP-2021-1\pro lab\proyectoahorasi\Main\NARANJA\Views\Cliente\BoletaCliente.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout="_LayoutCliente";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"" >BOLETA</h1>
<hr width=""400"" size=""15"" noshade=""noshade"">


<br>
<br>

<div class=""container"">
  <div class=""row"">
    <div class=""col-4"">
                               <strong>N°</strong> 
    </div>
    <div class=""col-4"">
                            <strong> DESCRIPCION</strong>
    </div>
    <div class=""col-4"">
                          <strong>COSTO</strong>  
    </div>
  </div>
</div>

<br>

<div class=""container"">
  <div class=""row"">
    <div class=""col-4"">
      1
    </div>
    <div class=""col-4"">
     Salchipapa 
    </div>
    <div class=""col-4"">
      $/. 15.00 
    </div>
  </div>
</div>

<br>
<br>

<div class="" alert alert-info text-right"">
    TOTAL: $/.15.00
</div>

<br>
<br>

<div>
<button type=""button"" class=""btn btn-success center"">VOLVER</button>
</div>");
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
