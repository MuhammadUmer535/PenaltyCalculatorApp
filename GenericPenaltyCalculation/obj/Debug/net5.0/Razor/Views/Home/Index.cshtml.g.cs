#pragma checksum "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64fd63ef8e69a5e608ef221dd716830c0706d5b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\_ViewImports.cshtml"
using GenericPenaltyCalculation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\_ViewImports.cshtml"
using GenericPenaltyCalculation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64fd63ef8e69a5e608ef221dd716830c0706d5b2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e23f6b9b2d96b5603139117c07bf005d7055d09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PenaltyCalculationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Penalty Calculator";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""panel panel-default form-panel container"">
        <div class=""panel-heading"" style=""text-align:center;"">
                <h3>Generic Penalty Calculator</h3>
            <br><br>
        </div>

        <div class=""panel-body"">
            <div class=""message-error"">
                ");
#nullable restore
#line 20 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>



            <div class=""row"" style=""margin-bottom:40px;"">
                <div class=""col-md-12 col-sm-12 col-xs-12"">
                    <div class=""col-md-3 col-sm-3 col-xs-12 formContainer"">

                        <div class=""form-group row"">
                            <label>Select a Country</label>
                            ");
#nullable restore
#line 31 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
                       Write(Html.DropDownListFor(model => model.selectedCountry, Model.LstCountries, new { @class = "form-control", @placeholder = "Countries" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 32 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.selectedCountry, String.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                    </div>
                    <div class=""col-md-4 col-sm-4 col-xs-12 formContainer"">

                        <div class=""form-group row"">
                            <label>Select Start Date</label>
                            ");
#nullable restore
#line 40 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(model => model.StartDate, new { htmlAttributes = new { @class = "form-control datepicker" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 41 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.selectedCountry, String.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>

                    </div>
                    <div class=""col-md-4 col-sm-4 col-xs-12 formContainer"">

                        <div class=""form-group row"">
                            <label>Select End Date</label>
                            ");
#nullable restore
#line 50 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(model => model.EndDate, new { htmlAttributes = new { @class = "form-control datepicker" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 51 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.selectedCountry, String.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>

                    </div>
                </div>
            </div>

            <div style=""text-align:center;"">
                <button class=""btn btn-primary btn-ghost btn-fill-up"">Calculate Penalty</button>
            </div>
            <br><br>
            <div style=""text-align:center;"">
                <h1 style=""font-weight:300; font-size:5rem;"">");
#nullable restore
#line 64 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
                                                         Write(Model.penaltyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 68 "C:\Users\muham\source\repos\GenericPenaltyCalculation\GenericPenaltyCalculation\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PenaltyCalculationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
