#pragma checksum "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17eada8ceb32804914c66fb83b9b8f105b091852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User__UserProfileInfo), @"mvc.1.0.view", @"/Views/User/_UserProfileInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17eada8ceb32804914c66fb83b9b8f105b091852", @"/Views/User/_UserProfileInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7b8880ea49463149f587326c9bcfc64cd7c9e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User__UserProfileInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_0_MyNiaSmartQuery.Contract.User.UserInfoQueryModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"






<div id=""about-me"" class=""tab-pane fade active show"">
    <div class=""profile-personal-info"" style=""padding:20px"">
        <h4 class=""text-primary mb-4"">اطلاعات شخصی</h4>
        <div class=""row mb-2"">
            <div class=""col-3"">
                <h5 class=""f-w-500"">
                    نام و نام خانوادگی<span class=""pull-right"">:</span>
                </h5>
            </div>
            <div class=""col-9"">
                <span>");
#nullable restore
#line 19 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileInfo.cshtml"
                 Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
        <div class=""row mb-2"">
            <div class=""col-3"">
                <h5 class=""f-w-500"">
                    کد ملی <span class=""pull-right"">:</span>
                </h5>
            </div>
            <div class=""col-9"">
                <span>");
#nullable restore
#line 29 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileInfo.cshtml"
                 Write(Model.NationalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
        <div class=""row mb-2"">
            <div class=""col-3"">
                <h5 class=""f-w-500"">تاریخ تولد <span class=""pull-right"">:</span></h5>
            </div>
            <div class=""col-9"">
                <span>");
#nullable restore
#line 37 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileInfo.cshtml"
                 Write(Model.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
        <div class=""row mb-2"">
            <div class=""col-3"">
                <h5 class=""f-w-500"">شهر <span class=""pull-right"">:</span></h5>
            </div>
            <div class=""col-9"">
                <span>");
#nullable restore
#line 45 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileInfo.cshtml"
                 Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
        <div class=""row mb-2"">
            <div class=""col-3"">
                <h5 class=""f-w-500"">استان <span class=""pull-right"">:</span></h5>
            </div>
            <div class=""col-9"">
                <span>");
#nullable restore
#line 53 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileInfo.cshtml"
                 Write(Model.Capital);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
            </div>
        </div>
        <div class=""row mb-2"">
            <div class=""col-3"">
                <h5 class=""f-w-500"">آدرس <span class=""pull-right"">:</span></h5>
            </div>
            <div class=""col-9"">
                <span>");
#nullable restore
#line 61 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileInfo.cshtml"
                 Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
            </div>
        </div>
        <div class=""row mb-2"">
            <div class=""col-3"">
                <h5 class=""f-w-500"">نام و نام خانوادگی معرف <span class=""pull-right"">:</span></h5>
            </div>
            <div class=""col-9"">
                <span>");
#nullable restore
#line 69 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileInfo.cshtml"
                 Write(Model.IntroductorFullname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
            </div>
        </div>
        <div class=""row mb-2"">
            <div class=""col-3"">
                <h5 class=""f-w-500"">شماره همراه معرف <span class=""pull-right"">:</span></h5>
            </div>
            <div class=""col-9"">
                <span> ");
#nullable restore
#line 77 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\User\_UserProfileInfo.cshtml"
                  Write(Model.IntroductorMobileNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_0_MyNiaSmartQuery.Contract.User.UserInfoQueryModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
