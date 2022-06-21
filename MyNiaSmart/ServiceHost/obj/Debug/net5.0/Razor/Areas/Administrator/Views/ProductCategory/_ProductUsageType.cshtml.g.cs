#pragma checksum "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Areas\Administrator\Views\ProductCategory\_ProductUsageType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed9c2b7158091d9b683789d39effca9c9c40a481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_ProductCategory__ProductUsageType), @"mvc.1.0.view", @"/Areas/Administrator/Views/ProductCategory/_ProductUsageType.cshtml")]
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
#line 1 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Areas\Administrator\Views\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Areas\Administrator\Views\_ViewImports.cshtml"
using ServiceHost.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed9c2b7158091d9b683789d39effca9c9c40a481", @"/Areas/Administrator/Views/ProductCategory/_ProductUsageType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7b8880ea49463149f587326c9bcfc64cd7c9e9", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administrator_Views_ProductCategory__ProductUsageType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShopManagement.Application.Contract.ProductCategory.ProductUsageType.ProductUsageTypeViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <button type=""button"" class=""btn btn-rounded btn-info"" onclick=""window.location.href ='#showmodal=/administrator/productcategory/_ProductUsageTypeCreate'"">
                    <span class=""btn-icon-left text-info"">
                        <i class=""fa fa-plus color-info""></i>
                    </span>افزودن
                </button>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-responsive-md"">
                        <thead>
                            <tr>
                                <th style=""width:50px;"">
                                    <div class=""custom-control custom-checkbox checkbox-success check-lg mr-3"">
                                        <input type=""checkbox"" class=""custom-control-input"" id=""checkAll""");
            BeginWriteAttribute("required", " required=\"", 1099, "\"", 1110, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <label class=""custom-control-label"" for=""checkAll""></label>
                                    </div>
                                </th>
                                <th><strong>(farsi)عنوان</strong></th>
                                <th><strong>(english)عنوان</strong></th>
                                <th><strong>عملیات</strong></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 32 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Areas\Administrator\Views\ProductCategory\_ProductUsageType.cshtml"
                             if (Model != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Areas\Administrator\Views\ProductCategory\_ProductUsageType.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td>
                                            <div class=""custom-control custom-checkbox checkbox-success check-lg mr-3"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheckBox2""");
            BeginWriteAttribute("required", " required=\"", 2118, "\"", 2129, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <label class=""custom-control-label"" for=""customCheckBox2""></label>
                                            </div>
                                        </td>
                                        <td><strong>");
#nullable restore
#line 43 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Areas\Administrator\Views\ProductCategory\_ProductUsageType.cshtml"
                                               Write(item.FarsiTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                                        <td><strong>");
#nullable restore
#line 44 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Areas\Administrator\Views\ProductCategory\_ProductUsageType.cshtml"
                                               Write(item.EngTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                                        <td>\r\n                                            <div class=\"d-flex\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2676, "\"", 2755, 2);
            WriteAttributeValue("", 2683, "#showmodal=/administrator/productcategory/_ProductUsageTypeEdit/", 2683, 64, true);
#nullable restore
#line 47 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Areas\Administrator\Views\ProductCategory\_ProductUsageType.cshtml"
WriteAttributeValue("", 2747, item.Id, 2747, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary shadow btn-xs sharp mr-1""><i class=""fa fa-pencil""></i></a>
                                                <a href=""#"" class=""btn btn-danger shadow btn-xs sharp""><i class=""fa fa-trash""></i></a>
                                            </div>
                                        </td>
                                    </tr>
");
#nullable restore
#line 52 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Areas\Administrator\Views\ProductCategory\_ProductUsageType.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Areas\Administrator\Views\ProductCategory\_ProductUsageType.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShopManagement.Application.Contract.ProductCategory.ProductUsageType.ProductUsageTypeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
