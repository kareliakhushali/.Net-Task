#pragma checksum "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1_login\Capstonedb1\Views\Registration\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "112b49d3fd259d07cfc5710480c5131593366159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_Login), @"mvc.1.0.view", @"/Views/Registration/Login.cshtml")]
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
#line 1 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1_login\Capstonedb1\Views\_ViewImports.cshtml"
using Capstonedb1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1_login\Capstonedb1\Views\_ViewImports.cshtml"
using Capstonedb1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1_login\Capstonedb1\Views\_ViewImports.cshtml"
using Capstonedb1.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1_login\Capstonedb1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"112b49d3fd259d07cfc5710480c5131593366159", @"/Views/Registration/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4c0afb8a76e33b83cfd4d208e2b0c420e63074", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Registration/FindUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1_login\Capstonedb1\Views\Registration\Login.cshtml"
   Layout = ViewBag.Layout; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1_login\Capstonedb1\Views\Registration\Login.cshtml"
 if (TempData["ErrorMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-danger\">");
#nullable restore
#line 5 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1_login\Capstonedb1\Views\Registration\Login.cshtml"
                        Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 6 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1_login\Capstonedb1\Views\Registration\Login.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-success\">");
#nullable restore
#line 8 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1_login\Capstonedb1\Views\Registration\Login.cshtml"
                     Write(ViewData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "112b49d3fd259d07cfc5710480c51315933661596267", async() => {
                WriteLiteral(@"

    <div class=""form-group row mb-3"">
        <label for=""email"" class=""col-sm-2 col-form-label"">Email:</label>
        <div class=""col-sm-10"">
            <input type=""email"" class=""form-control"" id=""email"" name=""email"" required>
            <span id=""email-error"" class=""text-danger""></span>
        </div>
    </div>

    <div class=""form-group row mb-3"">
        <label for=""password"" class=""col-sm-2 col-form-label"">Password:</label>
        <div class=""col-sm-10"">
            <input type=""password"" class=""form-control"" id=""password"" name=""password"" required>
            <span id=""password-error"" class=""text-danger""></span>
        </div>
    </div>

    <div class=""form-group row"">
        <div class=""col-sm-2""></div>
        <div class=""col-sm-10"">
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $(document).ready(function () {
        $('form').submit(function (event) {
            var email = $('#email').val();
            var password = $('#password').val();
            var isValid = true;

            if (!email || !email.trim()) {
                $('#email-error').text('Please enter a valid email address').addClass('text-danger');
                isValid = false;
            } else {
                $('#email-error').text('').removeClass('text-danger');
            }

            if (!password || !password.trim()) {
                $('#password-error').text('Please enter a valid password').addClass('text-danger');
                isValid = false;
            } else {
                $('#password-error').text('').removeClass('text-danger');
            }
        });
    });
</script>
");
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
