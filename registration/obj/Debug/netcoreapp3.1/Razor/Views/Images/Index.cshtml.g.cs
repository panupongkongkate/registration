#pragma checksum "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d2cdd1c3626ae801fd828e4fca8042b1901b1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Images_Index), @"mvc.1.0.view", @"/Views/Images/Index.cshtml")]
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
#line 1 "G:\Users\57120042\Desktop\repos\registration\registration\Views\_ViewImports.cshtml"
using registration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Users\57120042\Desktop\repos\registration\registration\Views\_ViewImports.cshtml"
using registration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d2cdd1c3626ae801fd828e4fca8042b1901b1b", @"/Views/Images/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6951798f5f85dfafa979c191da35bfd6e1fbf3ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Images_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<registration.Models.Images>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ระบบสมาชิก</h1>\r\n\r\n<p>\r\n");
            WriteLiteral("\r\n    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 192, "\"", 255, 3);
            WriteAttributeValue("", 202, "showInPopup(\'", 202, 13, true);
#nullable restore
#line 13 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
WriteAttributeValue("", 215, Url.Action("Create","Images"), 215, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 245, "\',\'Image\')", 245, 10, true);
            EndWriteAttribute();
            WriteLiteral(@"
       class=""btn btn-success text-white"">Add</a>

</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                No.
            </th>
            <th>
                Image
            </th>
            <th>
                ");
#nullable restore
#line 27 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 37 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phonenumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GenderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PositionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 55 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n\r\n");
#nullable restore
#line 59 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
                  
                    i++;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 63 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n            </td>\r\n\r\n            <td>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "17d2cdd1c3626ae801fd828e4fca8042b1901b1b8390", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
               WriteLiteral("~/Images/" + item.ImageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 68 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 82 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phonenumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 92 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender.GenderName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Position.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n");
            WriteLiteral("\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2767, "\"", 2847, 3);
            WriteAttributeValue("", 2777, "showInPopup(\'", 2777, 13, true);
#nullable restore
#line 103 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
WriteAttributeValue("", 2790, Url.Action("Edit","Images",new {id = item.ID}), 2790, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2837, "\',\'Image\')", 2837, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\">Edit </a>\r\n                \r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2928, "\"", 3011, 3);
            WriteAttributeValue("", 2938, "showInPopup(\'", 2938, 13, true);
#nullable restore
#line 105 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
WriteAttributeValue("", 2951, Url.Action("Details","Images",new {id = item.ID}), 2951, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3001, "\',\'Image\')", 3001, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\">Details </a>\r\n                \r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3095, "\"", 3177, 3);
            WriteAttributeValue("", 3105, "showInPopup(\'", 3105, 13, true);
#nullable restore
#line 107 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
WriteAttributeValue("", 3118, Url.Action("Delete","Images",new {id = item.ID}), 3118, 49, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3167, "\',\'Image\')", 3167, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\">Delete </a>\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 111 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Images\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<registration.Models.Images>> Html { get; private set; }
    }
}
#pragma warning restore 1591
