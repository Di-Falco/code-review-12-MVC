#pragma checksum "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18836aecedac7fea8b3df5e6ca48029dd159c810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Register), @"mvc.1.0.view", @"/Views/Accounts/Register.cshtml")]
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
#nullable restore
#line 1 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Register.cshtml"
using ParksMVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18836aecedac7fea8b3df5e6ca48029dd159c810", @"/Views/Accounts/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152f10bb8bf62bbede4b67b33807c0c43fd44457", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Accounts_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h4>Register a New Account</h4>\n<hr />\n");
#nullable restore
#line 6 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Register.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <table class=\"table\">\n    <tr>\n      <th>");
#nullable restore
#line 10 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Register.cshtml"
     Write(Html.LabelFor(user => user.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n      <td>");
#nullable restore
#line 11 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Register.cshtml"
     Write(Html.TextBoxFor(user => user.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n      <th>");
#nullable restore
#line 14 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Register.cshtml"
     Write(Html.LabelFor(user => user.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n      <td>");
#nullable restore
#line 15 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Register.cshtml"
     Write(Html.PasswordFor(user => user.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n      <th>");
#nullable restore
#line 18 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Register.cshtml"
     Write(Html.LabelFor(user => user.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n      <td>");
#nullable restore
#line 19 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Register.cshtml"
     Write(Html.PasswordFor(user => user.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n  </table>\n  <button class=\"btn btn-primary\" type=\"submit\">Register</button>\n");
#nullable restore
#line 23 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
