#pragma checksum "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b472d1f69131950b3d76d407acb8053a6256b92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GobernaRegistroBio.App.Frontend.Pages.Listas7.Pages_Listas7_EliminarSecretarios_Despacho), @"mvc.1.0.razor-page", @"/Pages/Listas7/EliminarSecretarios_Despacho.cshtml")]
namespace GobernaRegistroBio.App.Frontend.Pages.Listas7
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
#line 1 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\_ViewImports.cshtml"
using GobernaRegistroBio.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b472d1f69131950b3d76d407acb8053a6256b92", @"/Pages/Listas7/EliminarSecretarios_Despacho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed60cc198aa389ab14d58c9acc80749726dda1e2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas7_EliminarSecretarios_Despacho : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Se va a eliminar secretarios de despacho</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>");
#nullable restore
#line 8 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
       Write(Model.secretarios_despacho.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
       Write(Model.secretarios_despacho.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 10 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
       Write(Model.secretarios_despacho.Identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 11 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
       Write(Model.secretarios_despacho.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 12 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
       Write(Model.secretarios_despacho.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
       Write(Model.secretarios_despacho.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
       Write(Model.secretarios_despacho.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
       Write(Model.secretarios_despacho.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
       Write(Model.secretarios_despacho.Ubicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n        <td>");
#nullable restore
#line 17 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
       Write(Model.secretarios_despacho.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>     \r\n        \r\n       \r\n    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b472d1f69131950b3d76d407acb8053a6256b927563", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b472d1f69131950b3d76d407acb8053a6256b927825", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 23 "C:\Users\jfao3\OneDrive\Escritorio\Gobernacion\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas7\EliminarSecretarios_Despacho.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.secretarios_despacho.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <button type=\"submit\" class=\"btn btn-primary\">Confirmar Eliminar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GobernaRegistroBio.App.Frontend.Pages.EliminarSecretarios_DespachoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GobernaRegistroBio.App.Frontend.Pages.EliminarSecretarios_DespachoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GobernaRegistroBio.App.Frontend.Pages.EliminarSecretarios_DespachoModel>)PageContext?.ViewData;
        public GobernaRegistroBio.App.Frontend.Pages.EliminarSecretarios_DespachoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
