#pragma checksum "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dcd54bf21aaefae8521ad2926c29c730459d82a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parks_Edit), @"mvc.1.0.view", @"/Views/Parks/Edit.cshtml")]
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
#line 1 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/_ViewImports.cshtml"
using ParksMVC.Solution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/_ViewImports.cshtml"
using ParksMVC.Solution.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dcd54bf21aaefae8521ad2926c29c730459d82a", @"/Views/Parks/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152f10bb8bf62bbede4b67b33807c0c43fd44457", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Parks_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ParksMVC.Models.Park>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h4>Edit Park Details</h4>\n\n");
#nullable restore
#line 5 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
 using (Html.BeginForm("Edit", "Parks", FormMethod.Post))
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
Write(Html.HiddenFor(model => model.ParkId));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <table class=\"table\">\n    <tr>\n      <th>");
#nullable restore
#line 10 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
     Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n      <td>");
#nullable restore
#line 11 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
     Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n      <th>");
#nullable restore
#line 14 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
     Write(Html.LabelFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n      <td>");
#nullable restore
#line 15 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
     Write(Html.TextBoxFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n      <th>");
#nullable restore
#line 18 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
     Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n      <td><textarea rows=\"3\" cols=\"60\" name=\"Description\">");
#nullable restore
#line 19 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
                                                     Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea></td>\n    </tr>\n    <tr>\n      <th>");
#nullable restore
#line 22 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
     Write(Html.LabelFor(model => model.PhotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n      <td>");
#nullable restore
#line 23 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
     Write(Html.TextBoxFor(model => model.PhotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n  </table>\n");
            WriteLiteral("  <button type=\"submit\" class=\"btn btn-primary\">Submit Changes</button>\n");
#nullable restore
#line 28 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Parks/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ParksMVC.Models.Park> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
