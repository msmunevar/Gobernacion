#pragma checksum "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dc00358bbcaf4a4088386882aed2f95d17de0c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GobernaRegistroBio.App.Frontend.Pages.Listas.Pages_Listas_EliminarPersonal_Aseo), @"mvc.1.0.razor-page", @"/Pages/Listas/EliminarPersonal_Aseo.cshtml")]
namespace GobernaRegistroBio.App.Frontend.Pages.Listas
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
#line 1 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\_ViewImports.cshtml"
using GobernaRegistroBio.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dc00358bbcaf4a4088386882aed2f95d17de0c0", @"/Pages/Listas/EliminarPersonal_Aseo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed60cc198aa389ab14d58c9acc80749726dda1e2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_EliminarPersonal_Aseo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<h1>Se va a eliminar la persona de aseo</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>");
#nullable restore
#line 8 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml"
       Write(Model.personal_aseo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 9 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml"
       Write(Model.personal_aseo.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 10 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml"
       Write(Model.personal_aseo.Identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 11 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml"
       Write(Model.personal_aseo.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 12 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml"
       Write(Model.personal_aseo.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml"
       Write(Model.personal_aseo.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml"
       Write(Model.personal_aseo.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml"
       Write(Model.personal_aseo.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n        <td>");
#nullable restore
#line 16 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml"
       Write(Model.personal_aseo.Turno_Servicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dc00358bbcaf4a4088386882aed2f95d17de0c06772", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3dc00358bbcaf4a4088386882aed2f95d17de0c07034", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 20 "C:\Gobern\Gobernacion-1\GobernaRegistroBio.App\GobernaRegistroBio.App.Frontend\Pages\Listas\EliminarPersonal_Aseo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.personal_aseo.Id);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GobernaRegistroBio.App.Frontend.Pages.EliminarPersonal_AseoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GobernaRegistroBio.App.Frontend.Pages.EliminarPersonal_AseoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GobernaRegistroBio.App.Frontend.Pages.EliminarPersonal_AseoModel>)PageContext?.ViewData;
        public GobernaRegistroBio.App.Frontend.Pages.EliminarPersonal_AseoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
