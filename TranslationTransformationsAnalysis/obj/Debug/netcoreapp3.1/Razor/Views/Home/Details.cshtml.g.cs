#pragma checksum "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9321e3af476df2775c829c535086dfbf72906ee1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\_ViewImports.cshtml"
using TranslationTransformationsAnalysis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\_ViewImports.cshtml"
using TranslationTransformationsAnalysis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9321e3af476df2775c829c535086dfbf72906ee1", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0707392cc740005c5e3c8f04be06ddc99b31cf67", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TranslationTransformationsAnalysis.Models.TransformationUnit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row text-left mb-5\">\r\n        <dt class=\"col-md-2\">\r\n          Оригінал\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Original));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-2\">\r\n           Переклад\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Translation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <div class=\"ml-1\">\r\n\r\n                <div class=\"ml-1 mb-3\">\r\n\r\n");
#nullable restore
#line 29 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      if (Model.FormalFonLevel != null | Model.FormalLekLevel != null | Model.FormalMorfLevel != null | Model.FormalSlovLevel != null | Model.FormalSyntLevel != null)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5> Формальні трансформації </h5>\r\n");
#nullable restore
#line 33 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"


                        }

                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <dl class=\"row ml-4\">\r\n\r\n");
#nullable restore
#line 41 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      
                        if (Model.FormalFonLevel != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt class=\"col-md-2\">\r\n                                Фонетичний рівень\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 48 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(model => model.FormalFonLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n");
#nullable restore
#line 50 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      
                        if (Model.FormalLekLevel != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt class=\"col-md-2\">\r\n                                Лексичний рівень\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 60 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(model => model.FormalLekLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n");
#nullable restore
#line 62 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      
                        if (Model.FormalMorfLevel != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt class=\"col-md-2\">\r\n                                Морфологічний рівень\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 71 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(model => model.FormalMorfLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n");
#nullable restore
#line 73 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      
                        if (Model.FormalSlovLevel != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt class=\"col-md-2\">\r\n                                Словниковий рівень\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 82 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(model => model.FormalSlovLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n");
#nullable restore
#line 84 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      
                        if (Model.FormalSyntLevel != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt class=\"col-md-2\">\r\n                                Синтаксичний рівень\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 93 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(model => model.FormalSyntLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n");
#nullable restore
#line 95 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </dl>\r\n\r\n                <div class=\"border-bottom border-top mt-5\">\r\n\r\n\r\n                    <div class=\"ml-1 mb-3\">\r\n\r\n");
#nullable restore
#line 104 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                          if (Model.ContextFonLevel != null | Model.ContextLekLevel != null | Model.ContextMorfLevel != null | Model.ContextSyntLevel != null)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5> Формально-змістові трансформації </h5>\r\n");
#nullable restore
#line 108 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"


                            }

                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                    <dl class=\"row ml-4\">\r\n\r\n");
#nullable restore
#line 117 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                          
                            if (Model.ContextFonLevel != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dt class=\"col-md-2\">\r\n                                    Фонетичний рівень\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 124 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContextFonLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n");
#nullable restore
#line 126 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 129 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                          
                            if (Model.ContextLekLevel != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dt class=\"col-md-2\">\r\n                                    Лексичний рівень\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 136 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContextLekLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n");
#nullable restore
#line 138 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                          
                            if (Model.ContextMorfLevel != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dt class=\"col-md-2\">\r\n                                    Морфологічний рівень\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 147 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContextMorfLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n");
#nullable restore
#line 149 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                          
                            if (Model.ContextSyntLevel != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dt class=\"col-md-2\">\r\n                                    Синтаксичний рівень\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 158 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContextSyntLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n");
#nullable restore
#line 160 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </dl>\r\n                </div>\r\n                <div class=\"ml-1\">\r\n\r\n");
#nullable restore
#line 166 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      if (Model.PragmalPragmalFraTtransformation != null | Model.PragmalMegTransformation != null | Model.PragmalKoncTransformation != null | Model.PragmalAxTransformation != null)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5> Прагматичні трансформації </h5>\r\n");
#nullable restore
#line 170 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"


                        }

                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <dl class=\"row ml-4\">\r\n\r\n");
#nullable restore
#line 178 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      
                        if (Model.PragmalPragmalFraTtransformation != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt class=\"col-md-2\">\r\n                                Фразеологічні трансформації\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 185 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(model => model.PragmalPragmalFraTtransformation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n");
#nullable restore
#line 187 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 190 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      
                        if (Model.PragmalMegTransformation != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt class=\"col-md-2\">\r\n                                Мегатекстові трансформації\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 197 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(model => model.PragmalMegTransformation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n");
#nullable restore
#line 199 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 201 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      
                        if (Model.PragmalKoncTransformation != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt class=\"col-md-2\">\r\n                                Концептуальні перетворення\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 208 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(model => model.PragmalKoncTransformation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n");
#nullable restore
#line 210 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 212 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                      
                        if (Model.PragmalAxTransformation != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt class=\"col-md-2\">\r\n                                Аксіологічні трансофрмації\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 219 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(model => model.PragmalAxTransformation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n");
#nullable restore
#line 221 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </dl>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9321e3af476df2775c829c535086dfbf72906ee124411", async() => {
                WriteLiteral("\r\n        <span style=\"color:green;\">\r\n            <i class=\"fas fa-pencil-alt\"> Edit</i>\r\n        </span>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 227 "C:\Users\LuxComp\source\repos\TranslationTransformationsAnalysis\TranslationTransformationsAnalysis\Views\Home\Details.cshtml"
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
            WriteLiteral("\r\n    <div class=\"float-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9321e3af476df2775c829c535086dfbf72906ee126758", async() => {
                WriteLiteral("\r\n            <span style=\"color:gray;\">\r\n                <i class=\"fas fa-arrow-left\">\r\n                    Back to List\r\n                </i>\r\n            </span>\r\n        ");
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TranslationTransformationsAnalysis.Models.TransformationUnit> Html { get; private set; }
    }
}
#pragma warning restore 1591
