#pragma checksum "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6283581f7ccd3a39b31514a01dc0cc09a843435b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Login), @"mvc.1.0.view", @"/Views/Accounts/Login.cshtml")]
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
#line 1 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Login.cshtml"
using ParksMVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6283581f7ccd3a39b31514a01dc0cc09a843435b", @"/Views/Accounts/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152f10bb8bf62bbede4b67b33807c0c43fd44457", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Accounts_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h4>Log into your account</h4>\n<hr />\n\n");
#nullable restore
#line 7 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Login.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Login.cshtml"
Write(Html.LabelFor(model => model.Username));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Login.cshtml"
Write(Html.TextBoxFor(model => model.Username));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Login.cshtml"
Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Login.cshtml"
Write(Html.PasswordFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <button class=\"btn btn-primary\" type=\"submit\">Log In</button>\n");
#nullable restore
#line 16 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Login.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n<a");
            BeginWriteAttribute("href", " href=\'", 365, "\'", 395, 1);
#nullable restore
#line 18 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Login.cshtml"
WriteAttributeValue("", 372, Url.Action("Register"), 372, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">Register a New Account</button></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591