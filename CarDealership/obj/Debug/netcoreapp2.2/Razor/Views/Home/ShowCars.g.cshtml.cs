#pragma checksum "/Users/Guest/Desktop/CarDealership/CarDealership/Views/Home/ShowCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cbbb5aa34d4c127c1000f8142261669067f140e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowCars), @"mvc.1.0.view", @"/Views/Home/ShowCars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowCars.cshtml", typeof(AspNetCore.Views_Home_ShowCars))]
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
#line 1 "/Users/Guest/Desktop/CarDealership/CarDealership/Views/Home/ShowCars.cshtml"
using CarDealership.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cbbb5aa34d4c127c1000f8142261669067f140e", @"/Views/Home/ShowCars.cshtml")]
    public class Views_Home_ShowCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 26, true);
            WriteLiteral("\n<h1>Car Dealership</h1>\n\n");
            EndContext();
#line 5 "/Users/Guest/Desktop/CarDealership/CarDealership/Views/Home/ShowCars.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(80, 32, true);
            WriteLiteral("    <p>There are no results</p>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/CarDealership/CarDealership/Views/Home/ShowCars.cshtml"
}

#line default
#line hidden
            BeginContext(114, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/CarDealership/CarDealership/Views/Home/ShowCars.cshtml"
     foreach (Car car in Model)
    {

#line default
#line hidden
            BeginContext(157, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(170, 8, false);
#line 12 "/Users/Guest/Desktop/CarDealership/CarDealership/Views/Home/ShowCars.cshtml"
       Write(car.Year);

#line default
#line hidden
            EndContext();
            BeginContext(178, 18, true);
            WriteLiteral("</li>\n        <li>");
            EndContext();
            BeginContext(197, 8, false);
#line 13 "/Users/Guest/Desktop/CarDealership/CarDealership/Views/Home/ShowCars.cshtml"
       Write(car.Make);

#line default
#line hidden
            EndContext();
            BeginContext(205, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/CarDealership/CarDealership/Views/Home/ShowCars.cshtml"
    }

#line default
#line hidden
            BeginContext(217, 46, true);
            WriteLiteral("</ul>\n\n<a href= \'/cars/new\'> Add a new car</a>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
