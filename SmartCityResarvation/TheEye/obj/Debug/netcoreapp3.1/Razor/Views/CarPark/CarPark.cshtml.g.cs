#pragma checksum "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9807c00450e0d7836239f050cfe1ee6bb9ae921e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarPark_CarPark), @"mvc.1.0.view", @"/Views/CarPark/CarPark.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9807c00450e0d7836239f050cfe1ee6bb9ae921e", @"/Views/CarPark/CarPark.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/Views/_ViewImports.cshtml")]
    public class Views_CarPark_CarPark : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TheEye.Entities.Concrete.CarPark>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/carpark.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
  
    ViewBag.Title = "Otopark Listesi";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
Write(await Html.PartialAsync("MainSite/_Banner"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <br />\r\n    <div class=\"input-group mb-3\">\r\n        <input id=\"input-text\" type=\"text\" class=\"form-control\" placeholder=\"Arama Yap...\" aria-label=\"Recipient\'s username\" aria-describedby=\"button-addon2\">\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-3\" style=\"max-width: 1540px;\">\r\n            <div class=\"row no-gutters\">\r\n                <div class=\"col-md-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9807c00450e0d7836239f050cfe1ee6bb9ae921e5328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 24 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                          Write(item.Company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <div class=""col-md-12"">
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th scope=""col"">Market</th>
                                            <th scope=""col"">Araç Yıkama</th>
                                            <th scope=""col"">Boş Park Yeri Sayısı</th>
                                            <th scope=""col"">Engelli Araç Parkı</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
");
#nullable restore
#line 38 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                             if (item.CarParkMarket)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Var</td>\r\n");
#nullable restore
#line 41 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Yok</td>\r\n");
#nullable restore
#line 45 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                             if (item.CarParkWashing)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Var</td>\r\n");
#nullable restore
#line 50 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Yok</td>\r\n");
#nullable restore
#line 54 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>");
#nullable restore
#line 55 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                           Write(item.CarParkMax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 56 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                             if (item.CarParkDisabled)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Var</td>\r\n");
#nullable restore
#line 59 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Yok</td>\r\n");
#nullable restore
#line 63 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <br />
                        <br />
");
#nullable restore
#line 71 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                          
                            var max = item.CarParkMax;
                            var nul = item.CarParkNull;
                            var yuzde = nul * 100 / max;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        Doluluk Oranı\r\n                        <div class=\"progress\">\r\n                            <div class=\"progress-bar bg-success\"\r\n                                 role=\"progressbar\"");
            BeginWriteAttribute("style", "\r\n                                 style=\"", 3760, "\"", 3816, 3);
            WriteAttributeValue("", 3802, "width:", 3802, 6, true);
#nullable restore
#line 80 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
WriteAttributeValue(" ", 3808, yuzde, 3809, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3815, "%", 3815, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", "\r\n                                 aria-valuenow=\"", 3817, "\"", 3873, 1);
#nullable restore
#line 81 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
WriteAttributeValue("", 3867, yuzde, 3867, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                 aria-valuemin=\"0\"\r\n                                 aria-valuemax=\"100\">\r\n                                ");
#nullable restore
#line 84 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                           Write(yuzde);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""container"">
                <p>
                    <br />
                    <button class=""btn btn-info"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
                        Otopark Detaylarını Getir
                    </button>
                </p>
                <div class=""collapse"" id=""collapseExample"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">İl</th>
                                        <th scope=""col"">İlçe</th>
                                        <th scope=""col"">Adres</th>
                    ");
            WriteLiteral(@"                    <th scope=""col"">Telefon</th>
                                        <th scope=""col"">E-mail</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>");
#nullable restore
#line 113 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                       Write(item.Company.CompanyCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 114 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                       Write(item.Company.CompanyDistrict);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 115 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                       Write(item.Company.CompanyAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 116 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                       Write(item.Company.CompanyPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 117 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                       Write(item.Company.CompanyMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 126 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TheEye.Entities.Concrete.CarPark>> Html { get; private set; }
    }
}
#pragma warning restore 1591
