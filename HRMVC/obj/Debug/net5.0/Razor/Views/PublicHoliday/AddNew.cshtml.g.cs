#pragma checksum "D:\MY Projects\HRMVC\HRMVC\Views\PublicHoliday\AddNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f005ba20385985056985bbc94924fbd87d3fd003"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PublicHoliday_AddNew), @"mvc.1.0.view", @"/Views/PublicHoliday/AddNew.cshtml")]
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
#line 1 "D:\MY Projects\HRMVC\HRMVC\Views\_ViewImports.cshtml"
using HRMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MY Projects\HRMVC\HRMVC\Views\_ViewImports.cshtml"
using HRMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f005ba20385985056985bbc94924fbd87d3fd003", @"/Views/PublicHoliday/AddNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2a8e0397e03e0acff92d0a7e4a717df6e993c46", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PublicHoliday_AddNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PublicHoliday", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""AddNew"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""AddNewBranch"">Add New</h5>
                <button type=""button"" class=""close-btn"" data-dismiss=""modal"" aria-hidden=""true""></button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f005ba20385985056985bbc94924fbd87d3fd0034528", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">

                    

                    <div class=""form-group"">
                        <label>English:</label>
                        <input type=""text"" class=""form-control"" name=""Enname"">
                    </div>
                    <div class=""form-group"">
                        <label>Arabic:</label>
                        <input type=""text"" class=""form-control"" name=""Arname"">
                    </div>
                    <div class=""form-group"">
                        <label>From Date:</label>
                        <input type=""date"" class=""form-control"" name=""Fdate"" id=""dateofbirth"">
                    </div>
                    <div class=""form-group"">
                        <label>To Date:</label>
                        <input type=""date"" class=""form-control"" name=""Tdate"" id=""dateofbirth"">
                    </div>

                </div>
                <div class=""modal-footer"">
                    <button type=""butto");
                WriteLiteral("n\" class=\"btn btn-secondary\" data-dismiss=\"modal\" aria-hidden=\"true\">Close</button>\r\n                    <button type=\"submit\" class=\"btn btn-primary\" data-save=\"modal\" value=\"AddNew\">Save </button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
<style type=""text/css"">
    [type=""date""] {
        background: #fff url(https://cdn1.iconfinder.com/data/icons/cc_mono_icon_set/blacks/16x16/calendar_2.png) 97% 50% no-repeat;
    }

        [type=""date""]::-webkit-inner-spin-button {
            display: none;
        }

        [type=""date""]::-webkit-calendar-picker-indicator {
            opacity: 0;
        }

    /* custom styles */
    body {
        padding: 4em;
        background: #e5e5e5;
        font: 13px/1.4 Geneva, 'Lucida Sans', 'Lucida Grande', 'Lucida Sans Unicode', Verdana, sans-serif;
    }

    label {
        display: block;
    }

    input {
        border: 1px solid #c4c4c4;
        border-radius: 5px;
        background-color: #fff;
        padding: 3px 5px;
        box-shadow: inset 0 3px 6px rgba(0,0,0,0.1);
        width: 190px;
    }
</style>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
