#pragma checksum "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cf3f7258de40774e66a6f1761cd93daea6278e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
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
#line 1 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cf3f7258de40774e66a6f1761cd93daea6278e5", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152f10bb8bf62bbede4b67b33807c0c43fd44457", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ParksMVC.Models.ApplicationUser>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>Hello ");
#nullable restore
#line 6 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Index.cshtml"
      Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  <a");
            BeginWriteAttribute("href", " href=\'", 149, "\'", 177, 1);
#nullable restore
#line 7 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Index.cshtml"
WriteAttributeValue("", 156, Url.Action("LogOff"), 156, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">Log Out</button></a>\n");
#nullable restore
#line 8 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <a");
            BeginWriteAttribute("href", " href=\'", 245, "\'", 275, 1);
#nullable restore
#line 11 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Index.cshtml"
WriteAttributeValue("", 252, Url.Action("Register"), 252, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">Register</button></a>\n  <a");
            BeginWriteAttribute("href", " href=\'", 335, "\'", 362, 1);
#nullable restore
#line 12 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Index.cshtml"
WriteAttributeValue("", 342, Url.Action("Login"), 342, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">Log In</button></a>\n");
#nullable restore
#line 13 "/Users/difalcoa/Desktop/epicodus/ParksMVC.Solution/Views/Accounts/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ParksMVC.Models.ApplicationUser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
