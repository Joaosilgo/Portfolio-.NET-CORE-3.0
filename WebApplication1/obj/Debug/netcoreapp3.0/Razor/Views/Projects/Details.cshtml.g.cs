#pragma checksum "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a72c65f69f3f106c1ff8a7c906f4d8125e7bd8c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72c65f69f3f106c1ff8a7c906f4d8125e7bd8c4", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b287a0ce41c74eac714e19b3176d8ab5c2d19d0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<infoSys.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!DOCTYPE html>

<!-- #region Jumbotron -->
<!-- #end region Jumbotron -->



<div class=""container projectDetail"">



    <div class="" jumbotron jumbotron-fluid  p-3 p-md-5 text-white rounded bg-dark"">
        <div class=""col  col-sm-6 col-md-6 "">

            <h1 class=""display-1  display-4 font-italic"">");
#nullable restore
#line 21 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p class=\"lead my-3\">");
#nullable restore
#line 22 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                            Write(Html.DisplayFor(model => model.SmallDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"lead mb-0\"><a href=\"#Description\" class=\"text-white font-weight-bold\">Continue reading...</a></p>\r\n\r\n        </div>\r\n        </div>\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col col-sm-8 col-md-8\">\r\n\r\n\r\n");
            WriteLiteral(@"
            <div class=""img-fluid col col-sm-6 col-md-6 col-lg-6"">


                <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                    <ol class=""carousel-indicators"">
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                    </ol>
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
");
#nullable restore
#line 46 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                              
                                if (Model.imageContent != null && Model.imageMimeType.Contains("image"))
                                {
                                    string imageBase64 = Convert.ToBase64String(Model.imageContent);
                                    string imageSrc = string.Format("data:" + Model.imageMimeType + ";base64,{0}", imageBase64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", "  src=\"", 1988, "\"", 2004, 1);
#nullable restore
#line 51 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
WriteAttributeValue("", 1995, imageSrc, 1995, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2005, "\"", 2032, 2);
            WriteAttributeValue("", 2011, "Thumbnail", 2011, 9, true);
#nullable restore
#line 51 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
WriteAttributeValue(" ", 2020, Model.Name, 2021, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" />\r\n");
#nullable restore
#line 52 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                }
                                else
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a72c65f69f3f106c1ff8a7c906f4d8125e7bd8c49041", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                  \r\n\r\n");
#nullable restore
#line 62 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                             foreach (var item in Model.ProjectThumbnails)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                 if (@item.imageContent != null && @item.imageMimeType.Contains("image"))
                                {

                                    string imageBase64 = Convert.ToBase64String(@item.imageContent);
                                    string imageSrc = string.Format(" data:" + @item.imageMimeType + ";base64,{0}", imageBase64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"carousel-item\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2989, "\"", 3004, 1);
#nullable restore
#line 71 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
WriteAttributeValue("", 2995, imageSrc, 2995, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Thumbnail\" class=\"d-block w-100\">\r\n                                    </div>\r\n");
#nullable restore
#line 73 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                 

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Previous</span>
                        </a>
                        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </div>

");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n\r\n\r\n            <div>\r\n                <a class=\"badge badge-light text-secondary\">  ");
#nullable restore
#line 118 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                         Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                <a class=\"badge badge-light  text-secondary\"");
            BeginWriteAttribute("href", " href=\"", 4982, "\"", 5026, 1);
#nullable restore
#line 119 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
WriteAttributeValue("", 4989, Html.DisplayFor(model => model.Link), 4989, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-code-branch\"></i> SOURCE</a>\r\n                <p class=\" font-italic text-secondary\">");
#nullable restore
#line 120 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.SmallDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <hr />\r\n            <div class=\"text-secondary\">\r\n                <h3 class=\"my-sm-4 font-weight-bold\">Tecnologias</h3>\r\n                <div>\r\n                    <p class=\"font-italic multiline \"> ");
#nullable restore
#line 126 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.Languages));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral("        </div>\r\n\r\n\r\n\r\n        <div class=\"col col-sm-4 col-md-4\">\r\n");
#nullable restore
#line 136 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
              
                if (!String.IsNullOrEmpty(Model.Description))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"Description\">\r\n                        <h3 class=\"font-weight-bold my-3\">Project Description</h3>\r\n                        <hr />\r\n                        <p class=\"font-italic font-weight-bold text-secondary\">");
#nullable restore
#line 142 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                                          Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 144 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 147 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
              
                if (!String.IsNullOrEmpty(Model.Intent))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <h3 class=\"my-3 font-weight-bold\">  ");
#nullable restore
#line 151 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.Intent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"font-italic font-weight-bold text-secondary\">");
#nullable restore
#line 152 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                                          Write(Html.DisplayFor(model => model.Intent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <hr />\r\n                    </div>\r\n");
#nullable restore
#line 155 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                }

            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 159 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
              
                if (!String.IsNullOrEmpty(Model.Features))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <h3 class=\"my-3 font-weight-bold\">  ");
#nullable restore
#line 163 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.Features));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"font-italic font-weight-bold text-secondary\"> ");
#nullable restore
#line 164 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                                           Write(Html.DisplayFor(model => model.Features));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <hr />\r\n                    </div>\r\n");
#nullable restore
#line 167 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 170 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
              
                if (!String.IsNullOrEmpty(Model.Difficulties))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <h3 class=\"my-3 font-weight-bold\">  ");
#nullable restore
#line 174 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.Difficulties));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"font-italic font-weight-bold text-secondary\">");
#nullable restore
#line 175 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                                          Write(Html.DisplayFor(model => model.Difficulties));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <hr />\r\n                    </div>\r\n");
#nullable restore
#line 178 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 180 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
              
                if (!String.IsNullOrEmpty(Model.Solution))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <h3 class=\"my-3 font-weight-bold\">  ");
#nullable restore
#line 185 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.Solution));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"font-italic font-weight-bold text-secondary\">");
#nullable restore
#line 186 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                                                          Write(Html.DisplayFor(model => model.Solution));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <hr />\r\n                    </div>\r\n");
#nullable restore
#line 189 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-8\">\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 203 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
             if (User.IsInRole("Administrador"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a72c65f69f3f106c1ff8a7c906f4d8125e7bd8c423009", async() => {
                WriteLiteral("Edit");
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
#line 206 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
                                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a72c65f69f3f106c1ff8a7c906f4d8125e7bd8c425208", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 209 "C:\Users\joao2\OneDrive\Ambiente de Trabalho\Web\infoSys\WebApplication1\Views\Projects\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            WriteLiteral("<!-- /.container -->\r\n<!-- Bootstrap core JavaScript\r\n================================================== -->\r\n<!-- Placed at the end of the document so the pages load faster -->\r\n");
            WriteLiteral("<!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<infoSys.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
