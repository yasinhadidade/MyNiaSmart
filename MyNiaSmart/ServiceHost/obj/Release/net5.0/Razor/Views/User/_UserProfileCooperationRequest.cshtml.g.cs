#pragma checksum "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ef563a6a3a9a1aff25e94e18c816f9c9f72aac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User__UserProfileCooperationRequest), @"mvc.1.0.view", @"/Views/User/_UserProfileCooperationRequest.cshtml")]
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
#line 1 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\_ViewImports.cshtml"
using ServiceHost.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
using AccountManagement.Application.Contract.PersonalityType;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef563a6a3a9a1aff25e94e18c816f9c9f72aac1", @"/Views/User/_UserProfileCooperationRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7b8880ea49463149f587326c9bcfc64cd7c9e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User__UserProfileCooperationRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonalityTypeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/user/CooperationRequest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    .coopBtn {\r\n    \r\n    }\r\n</style>\r\n\r\n<div id=\"CooperationRequest\" class=\"tab-pane fade\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ef563a6a3a9a1aff25e94e18c816f9c9f72aac14426", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">شخصیت مورد نظرتان جهت همکاری با ما را انتخاب نمایید </h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""basic-list-group"">
                            <div class=""row"">
                                <div class=""col-lg-6 col-xl-2"">
                                    <div class=""list-group mb-4 "" id=""list-tab"" role=""tablist"">
");
#nullable restore
#line 23 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
                                         foreach (var personalityType in Model)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a");
                BeginWriteAttribute("class", " class=\"", 1028, "\"", 1127, 3);
                WriteAttributeValue("", 1036, "list-group-item", 1036, 15, true);
                WriteAttributeValue(" ", 1051, "list-group-item-action", 1052, 23, true);
#nullable restore
#line 25 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
WriteAttributeValue("  ", 1074, (Model.IndexOf(personalityType)==0)? "active":"", 1076, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1128, "\"", 1162, 3);
                WriteAttributeValue("", 1133, "list-", 1133, 5, true);
#nullable restore
#line 25 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
WriteAttributeValue("", 1138, personalityType.Id, 1138, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1157, "-list", 1157, 5, true);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"list\"");
                BeginWriteAttribute("href", " href=\"", 1182, "\"", 1214, 2);
                WriteAttributeValue("", 1189, "#list-", 1189, 6, true);
#nullable restore
#line 25 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
WriteAttributeValue("", 1195, personalityType.Id, 1195, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"tab\">");
#nullable restore
#line 25 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
                                                                                                                                                                                                                                                Write(personalityType.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 26 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n                                </div>\r\n                                <div class=\"col-lg-6 col-xl-10\">\r\n\r\n\r\n                                    <div class=\"tab-content\" id=\"nav-tabContent\">\r\n");
#nullable restore
#line 33 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
                                         foreach (var personalityType in Model)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div");
                BeginWriteAttribute("class", " class=\"", 1707, "\"", 1786, 4);
                WriteAttributeValue("", 1715, "tab-pane", 1715, 8, true);
                WriteAttributeValue(" ", 1723, "fade", 1724, 5, true);
#nullable restore
#line 35 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
WriteAttributeValue(" ", 1728, (Model.IndexOf(personalityType)==0)? "active show":"", 1729, 56, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1785, "", 1786, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1787, "\"", 1816, 2);
                WriteAttributeValue("", 1792, "list-", 1792, 5, true);
#nullable restore
#line 35 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
WriteAttributeValue("", 1797, personalityType.Id, 1797, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 36 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
                                                 foreach (var personality in personalityType.Personalities)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <div class=\"form-check mb-8\" style=\"padding:5px\">\r\n                                                        <input type=\"checkbox\" class=\"form-check-input\" id=\"check1\" name=\"PersonalityList\"");
                BeginWriteAttribute("value", " value=\"", 2221, "\"", 2244, 1);
#nullable restore
#line 39 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
WriteAttributeValue("", 2229, personality.Id, 2229, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                        <label class=\"form-check-label\" for=\"check1\"> ");
#nullable restore
#line 40 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
                                                                                                 Write(personality.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                                    </div>\r\n");
#nullable restore
#line 42 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </div>\r\n");
#nullable restore
#line 44 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileCooperationRequest.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </div>

                                </div>

                            </div>
                           <center> <button type=""submit"" class=""btn btn-rounded btn-outline-primary coopBtn"">ارسال درخواست</button></center>  
                        </div>
                    </div>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonalityTypeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
