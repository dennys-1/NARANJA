#pragma checksum "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\Reservas\Reservas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d5a5984cea3689339a9cf5ac97825bea45b048f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservas_Reservas), @"mvc.1.0.view", @"/Views/Reservas/Reservas.cshtml")]
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
#line 1 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\_ViewImports.cshtml"
using NARANJA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\_ViewImports.cshtml"
using NARANJA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d5a5984cea3689339a9cf5ac97825bea45b048f", @"/Views/Reservas/Reservas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04f2064ae81ce91a21a8bf46d9a57a003381edf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservas_Reservas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NARANJA.Models.Reservas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportarExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Lista Contactos</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d5a5984cea3689339a9cf5ac97825bea45b048f3812", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-hover\">\r\n     <thead class=\"thead-dark\">\r\n        <tr>\r\n                <th scope=\"col\">\r\n                    #\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 16 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\Reservas\Reservas.cshtml"
               Write(Html.DisplayNameFor(model => model.fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 19 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\Reservas\Reservas.cshtml"
               Write(Html.DisplayNameFor(model => model.n_personas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 22 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\Reservas\Reservas.cshtml"
               Write(Html.DisplayNameFor(model => model.ocasion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\Reservas\Reservas.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 31 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\Reservas\Reservas.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\Reservas\Reservas.cshtml"
               Write(Html.DisplayFor(modelItem => item.fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\Reservas\Reservas.cshtml"
               Write(Html.DisplayFor(modelItem => item.n_personas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\Reservas\Reservas.cshtml"
               Write(Html.DisplayFor(modelItem => item.ocasion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "D:\USMP-2021-1\pro lab\PROYECTO FINAL\Main base\NARANJA\Views\Reservas\Reservas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d5a5984cea3689339a9cf5ac97825bea45b048f8161", async() => {
                WriteLiteral("Exporta a Excel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NARANJA.Models.Reservas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
