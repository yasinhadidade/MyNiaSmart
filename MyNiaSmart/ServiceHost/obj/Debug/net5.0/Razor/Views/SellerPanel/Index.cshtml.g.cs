#pragma checksum "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\SellerPanel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8916ad309ce2cd75ae1eb0766751cd0f6d9ae343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SellerPanel_Index), @"mvc.1.0.view", @"/Views/SellerPanel/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8916ad309ce2cd75ae1eb0766751cd0f6d9ae343", @"/Views/SellerPanel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7b8880ea49463149f587326c9bcfc64cd7c9e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SellerPanel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShopManagement.Application.Contract.SellerProduct.SellerProductViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\SellerPanel\Index.cshtml"
  
    ViewData["Title"] = "پنل فروشندگی";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row page-titles mx-0"">
    <div class=""col-sm-6 p-md-0"">
        <div class=""welcome-text"">
            <h4>سلام، خوش آمدید</h4>
            <p class=""mb-0"">پنل فروشندگی</p>
        </div>
    </div>
    <div class=""col-sm-6 p-md-0 justify-content-sm-end mt-2 mt-sm-0 d-flex"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""javascript:void(0)"">پنل ها </a></li>
            <li class=""breadcrumb-item active""><a href=""javascript:void(0)"">پنل فروشندگی </a></li>
        </ol>
    </div>
</div>

<div class=""row"">
    <div class=""col-xl-12 col-lg-6 col-md-12 col-sm-12"">
        <a href=""/sellerpanel/createProduct"" class=""btn btn-square btn-outline-primary"" style=""width:100%"">افزودن محصول جدید</a>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-4 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""new-arrival-product"">
                    <div class=""new-arrivals-img-contnent"">
                 ");
            WriteLiteral("       <img class=\"img-fluid\" src=\"/MainTheme/images/product/1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1226, "\"", 1232, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""new-arrival-content text-center mt-3"">
                        <h4>بونوروم و مالوروم</h4>
                        <ul class=""star-rating"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star-half-empty""></i></li>
                            <li><i class=""fa fa-star-half-empty""></i></li>
                        </ul>
                        <span class=""price"">76000 تومان</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-4 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""new-arrival-product"">
                    <div class=""new-arrivals-img-contnent"">
                        <img class=""img-fluid");
            WriteLiteral("\" src=\"/MainTheme/images/product/2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2296, "\"", 2302, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""new-arrival-content text-center mt-3"">
                        <h4>لباس راه راه</h4>
                        <ul class=""star-rating"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span class=""price"">159000 تومان</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-4 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""new-arrival-product"">
                    <div class=""new-arrivals-img-contnent"">
                        <img class=""img-fluid"" src=""/MainTheme/images/p");
            WriteLiteral("roduct/3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3340, "\"", 3346, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""new-arrival-content text-center mt-3"">
                        <h4>خال خال</h4>
                        <ul class=""star-rating"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span class=""price"">36000 تومان</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-4 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""new-arrival-product"">
                    <div class=""new-arrivals-img-contnent"">
                        <img class=""img-fluid"" src=""/MainTheme/images/product");
            WriteLiteral("/4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4378, "\"", 4384, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""new-arrival-content text-center mt-3"">
                        <h4>Z محصول 360</h4>
                        <ul class=""star-rating"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star-half-empty""></i></li>
                            <li><i class=""fa fa-star-half-empty""></i></li>
                        </ul>
                        <span class=""price"">66000 تومان</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-4 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""new-arrival-product"">
                    <div class=""new-arrivals-img-contnent"">
                        <img class=""img-fluid"" src=");
            WriteLiteral("\"/MainTheme/images/product/5.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5442, "\"", 5448, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""new-arrival-content text-center mt-3"">
                        <h4>صندلی خاکستری</h4>
                        <ul class=""star-rating"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span class=""price"">96000 تومان</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-4 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""new-arrival-product"">
                    <div class=""new-arrivals-img-contnent"">
                        <img class=""img-fluid"" src=""/MainTheme/images/p");
            WriteLiteral("roduct/6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6486, "\"", 6492, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""new-arrival-content text-center mt-3"">
                        <h4>بخاطر روباه با</h4>
                        <ul class=""star-rating"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span class=""price"">69000 تومان</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-4 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""new-arrival-product"">
                    <div class=""new-arrivals-img-contnent"">
                        <img class=""img-fluid"" src=""/MainTheme/images/");
            WriteLiteral("product/7.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7531, "\"", 7537, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""new-arrival-content text-center mt-3"">
                        <h4>کوله پشتی</h4>
                        <ul class=""star-rating"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span class=""price"">96000 تومان</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-4 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""new-arrival-product"">
                    <div class=""new-arrivals-img-contnent"">
                        <img class=""img-fluid"" src=""/MainTheme/images/produ");
            WriteLiteral("ct/1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 8571, "\"", 8577, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""new-arrival-content text-center mt-3"">
                        <h4>لباس فلر</h4>
                        <ul class=""star-rating"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star-half-empty""></i></li>
                            <li><i class=""fa fa-star-half-empty""></i></li>
                        </ul>
                        <span class=""price"">5000 تومان</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShopManagement.Application.Contract.SellerProduct.SellerProductViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
