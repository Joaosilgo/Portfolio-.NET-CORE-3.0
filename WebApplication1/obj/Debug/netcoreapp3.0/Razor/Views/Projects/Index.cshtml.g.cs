#pragma checksum "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33fd5fb3de36ce5787416b4719a5eae62673eab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Index), @"mvc.1.0.view", @"/Views/Projects/Index.cshtml")]
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
#line 2 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\_ViewImports.cshtml"
using infoSys;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\_ViewImports.cshtml"
using infoSys.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33fd5fb3de36ce5787416b4719a5eae62673eab6", @"/Views/Projects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b287a0ce41c74eac714e19b3176d8ab5c2d19d0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<infoSys.Models.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("lightbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><span class=\"badge badge-secondary\">Projetos GitHub</span></h1>\r\n");
#nullable restore
#line 8 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
 if (User.IsInRole("Administrador"))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33fd5fb3de36ce5787416b4719a5eae62673eab65303", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
            WriteLiteral("<th>\r\n    ");
#nullable restore
#line 29 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</th>\r\n");
            WriteLiteral("<th>\r\n    ");
#nullable restore
#line 44 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</th>\r\n");
            WriteLiteral("<th>\r\n    ");
#nullable restore
#line 50 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
Write(Html.DisplayNameFor(model => model.Link));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</th>\r\n<th></th>\r\n        </tr>\r\n    </thead>\r\n<tbody>\r\n");
#nullable restore
#line 56 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n\r\n                <span class=\"badge badge-pill badge-info\">");
#nullable restore
#line 82 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n");
            WriteLiteral("                <a style=\"color:black\"");
            BeginWriteAttribute("href", " href=\"", 2403, "\"", 2450, 1);
#nullable restore
#line 90 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
WriteAttributeValue("", 2410, Html.DisplayFor(modelItem => item.Link), 2410, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fab fa-github fa-2x white-text mr-5\">  </i> </a>\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33fd5fb3de36ce5787416b4719a5eae62673eab610257", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 94 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                 if (User.IsInRole("Administrador"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33fd5fb3de36ce5787416b4719a5eae62673eab612738", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33fd5fb3de36ce5787416b4719a5eae62673eab614931", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 102 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>\r\n\r\n    -->\r\n \r\n");
            WriteLiteral("\r\n<section class=\"gallery-block cards-gallery\">\r\n\r\n    <div class=\"container\">\r\n        <div class=\"heading\">\r\n            <h2>Projects</h2>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 143 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-4\">\r\n                        <div class=\"card border-0 transform-on-hover embed-responsive \">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33fd5fb3de36ce5787416b4719a5eae62673eab618331", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 148 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                                  
                                    if (item.imageContent != null && item.imageMimeType.Contains("image"))
                                    {
                                        string imageBase64 = Convert.ToBase64String(item.imageContent);
                                        string imageSrc = string.Format("data:" + item.imageMimeType + ";base64,{0}", imageBase64);

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <img");
                BeginWriteAttribute("src", " src=\"", 5229, "\"", 5244, 1);
#nullable restore
#line 153 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
WriteAttributeValue("", 5235, imageSrc, 5235, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 5245, "\"", 5271, 2);
                WriteAttributeValue("", 5251, "Thumbnail", 5251, 9, true);
#nullable restore
#line 153 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
WriteAttributeValue(" ", 5260, item.Name, 5261, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
                WriteLiteral(" class=\"card-img-top img-fluid \" />\r\n");
#nullable restore
#line 154 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"card-body\">\r\n                                    <h6>");
#nullable restore
#line 157 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                    <p class=\"text-muted card-text\">");
#nullable restore
#line 158 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                                                               Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <span class=\"badge badge-pill badge-light\">");
#nullable restore
#line 159 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.Language));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 147 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                                \r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 176 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            </div>\r\n        </div>\r\n\r\n</section>\r\n\r\n");
            WriteLiteral(@"
<style>
    .gallery-block{ padding-bottom:60px; padding-top:60px;}
.gallery-block .heading{margin-bottom:50px; text-align:center; }

.gallery-block.cards-gallery .card{transition:0.4s ease;}
    .gallery-block.cards-gallery .card img{box-shadow:8px 2px 10px  rgba(0,0,0,0.15);}
    .gallery-block.cards-gallery a{color:#212529;}
        .gallery-block.cards-gallery a:hover{
            text-decoration: none;
        }
        .gallery-block.cards-gallery .card{
            margin-bottom:30px;
            box-shadow:0px 2px 10px rgba(0,0,0,0.15);
        }

    .card-img-top {
        width: 100%;
        height: 15vw;
        object-fit: cover;
    }

    ");
            WriteLiteral("@media (min-width:576px){\r\n         .gallery-block .transform-on-hover:hover{\r\n             transform: translateY(-10px) scale(1.02);\r\n                box-shadow:0px 10px 10px rgba(0,0,0,0.15) !important;\r\n         }\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<infoSys.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
