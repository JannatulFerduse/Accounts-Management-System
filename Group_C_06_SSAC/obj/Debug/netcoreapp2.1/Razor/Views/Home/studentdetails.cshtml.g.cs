#pragma checksum "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7323027eaef40d46758ada3b0df5bfdc097a4011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_studentdetails), @"mvc.1.0.view", @"/Views/Home/studentdetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/studentdetails.cshtml", typeof(AspNetCore.Views_Home_studentdetails))]
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
#line 1 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\_ViewImports.cshtml"
using Group_C_06_SSAC;

#line default
#line hidden
#line 2 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\_ViewImports.cshtml"
using Group_C_06_SSAC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7323027eaef40d46758ada3b0df5bfdc097a4011", @"/Views/Home/studentdetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b02e9b655b460dd9712fcd50683d7eb692ef6a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_studentdetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Group_C_06_SSAC.Models.payment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 458, true);
            WriteLiteral(@"
<br />
<br />

<div class=""container"">

    <table style=""width:100%"">
        <tr>


            <th>Date</th>
            <th>Admission Fees</th>
            <th>Monthly Fees</th>
            <th>Examination Fees</th>
            <th>Tie/Id card/Diary</th>
            <th>Syllabus</th>
            <th>Sports event</th>
            <th>Picnic</th>
            <th>Deu</th>
            <th>Total</th>
        </tr>
        <tbody>

");
            EndContext();
#line 25 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
             foreach (var x in Model)
            {

#line default
#line hidden
            BeginContext(558, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(597, 39, false);
#line 28 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
               Write(String.Format("{0:dd/MM/yyyy}", x.date));

#line default
#line hidden
            EndContext();
            BeginContext(636, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(664, 11, false);
#line 29 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
               Write(x.admission);

#line default
#line hidden
            EndContext();
            BeginContext(675, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(703, 9, false);
#line 30 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
               Write(x.monthly);

#line default
#line hidden
            EndContext();
            BeginContext(712, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(740, 5, false);
#line 31 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
               Write(x.xam);

#line default
#line hidden
            EndContext();
            BeginContext(745, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(773, 5, false);
#line 32 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
               Write(x.tie);

#line default
#line hidden
            EndContext();
            BeginContext(778, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(806, 10, false);
#line 33 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
               Write(x.syllabus);

#line default
#line hidden
            EndContext();
            BeginContext(816, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(844, 8, false);
#line 34 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
               Write(x.sports);

#line default
#line hidden
            EndContext();
            BeginContext(852, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(880, 8, false);
#line 35 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
               Write(x.picnic);

#line default
#line hidden
            EndContext();
            BeginContext(888, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(916, 5, false);
#line 36 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
               Write(x.due);

#line default
#line hidden
            EndContext();
            BeginContext(921, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(950, 82, false);
#line 37 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
                Write(x.admission + x.monthly + x.xam + x.tie + x.syllabus + x.sports + x.picnic - x.due);

#line default
#line hidden
            EndContext();
            BeginContext(1033, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 40 "F:\Project\Group06\Group_C_06_SSAC\Group_C_06_SSAC\Views\Home\studentdetails.cshtml"
            }

#line default
#line hidden
            BeginContext(1076, 42, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Group_C_06_SSAC.Models.payment>> Html { get; private set; }
    }
}
#pragma warning restore 1591