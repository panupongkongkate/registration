#pragma checksum "G:\Users\57120042\Desktop\repos\registration\registration\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "730ca551fcaec4eeedf19350f4d37f374947e4aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730ca551fcaec4eeedf19350f4d37f374947e4aa", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6951798f5f85dfafa979c191da35bfd6e1fbf3ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\Users\57120042\Desktop\repos\registration\registration\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730ca551fcaec4eeedf19350f4d37f374947e4aa4175", async() => {
                WriteLiteral(@"
        <h2>Registration</h2>
        <div class=""form-group"">
            <label for=""firstName"" class=""col-sm-3 control-label"">First Name</label>
            <div class=""col-sm-9"">
                <input type=""text"" id=""firstName"" placeholder=""First Name"" class=""form-control"" autofocus>
            </div>
        </div>
        <div class=""form-group"">
            <label for=""lastName"" class=""col-sm-3 control-label"">Last Name</label>
            <div class=""col-sm-9"">
                <input type=""text"" id=""lastName"" placeholder=""Last Name"" class=""form-control"" autofocus>
            </div>
        </div>
        <div class=""form-group"">
            <label for=""email"" class=""col-sm-3 control-label"">Email* </label>
            <div class=""col-sm-9"">
                <input type=""email"" id=""email"" placeholder=""Email"" class=""form-control"" name=""email"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""password"" class=""col-sm-3 control-label"">Password");
                WriteLiteral(@"*</label>
            <div class=""col-sm-9"">
                <input type=""password"" id=""password"" placeholder=""Password"" class=""form-control"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""password"" class=""col-sm-3 control-label"">Confirm Password*</label>
            <div class=""col-sm-9"">
                <input type=""password"" id=""password"" placeholder=""Password"" class=""form-control"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""birthDate"" class=""col-sm-3 control-label"">Date of Birth*</label>
            <div class=""col-sm-9"">
                <input type=""date"" id=""birthDate"" class=""form-control"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""phoneNumber"" class=""col-sm-3 control-label"">Phone number </label>
            <div class=""col-sm-9"">
                <input type=""phoneNumber"" id=""phoneNumber"" placeholder=""Phone number"" class=""form-control"">
      ");
                WriteLiteral(@"          <span class=""help-block"">Your phone number won't be disclosed anywhere </span>
            </div>
        </div>
        <div class=""form-group"">
            <label for=""Height"" class=""col-sm-3 control-label"">Height* </label>
            <div class=""col-sm-9"">
                <input type=""number"" id=""height"" placeholder=""Please write your height in centimetres"" class=""form-control"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""weight"" class=""col-sm-3 control-label"">Weight* </label>
            <div class=""col-sm-9"">
                <input type=""number"" id=""weight"" placeholder=""Please write your weight in kilograms"" class=""form-control"">
            </div>
        </div>
        <div class=""form-group"">
            <label class=""control-label col-sm-3"">Gender</label>
            <div class=""col-sm-6"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <label class=""radio-inline"">
     ");
                WriteLiteral(@"                       <input type=""radio"" id=""femaleRadio"" value=""Female"">Female
                        </label>
                    </div>
                    <div class=""col-sm-4"">
                        <label class=""radio-inline"">
                            <input type=""radio"" id=""maleRadio"" value=""Male"">Male
                        </label>
                    </div>
                </div>
            </div>
        </div> <!-- /.form-group -->
        <div class=""form-group"">
            <div class=""col-sm-9 col-sm-offset-3"">
                <span class=""help-block"">*Required fields</span>
            </div>
        </div>
        <button type=""submit"" class=""btn btn-primary btn-block"">Register</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <!-- /form -->\r\n</div> <!-- ./container -->\r\n");
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
