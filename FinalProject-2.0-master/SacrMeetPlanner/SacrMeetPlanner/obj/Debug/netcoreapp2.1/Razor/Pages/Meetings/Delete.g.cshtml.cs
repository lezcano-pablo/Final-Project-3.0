#pragma checksum "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad9cdb4bc42eb763795af4b9c1cbaef102adc3f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SacrMeetPlanner.Pages.Meetings.Pages_Meetings_Delete), @"mvc.1.0.razor-page", @"/Pages/Meetings/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Meetings/Delete.cshtml", typeof(SacrMeetPlanner.Pages.Meetings.Pages_Meetings_Delete), null)]
namespace SacrMeetPlanner.Pages.Meetings
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\_ViewImports.cshtml"
using SacrMeetPlanner;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad9cdb4bc42eb763795af4b9c1cbaef102adc3f6", @"/Pages/Meetings/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03fdf9f1b5100043b2397f779810e175d6fe7afb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Meetings_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(96, 163, true);
            WriteLiteral("\n<h2>Delete Meeting</h2>\n<hr />\n<h3 id=\"warning\">Are you sure you want to delete this meeting?</h3>\n\n<div>\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(260, 48, false);
#line 15 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.Date));

#line default
#line hidden
            EndContext();
            BeginContext(308, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(349, 44, false);
#line 18 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.Date));

#line default
#line hidden
            EndContext();
            BeginContext(393, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(434, 54, false);
#line 21 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.Conducting));

#line default
#line hidden
            EndContext();
            BeginContext(488, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(529, 50, false);
#line 24 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.Conducting));

#line default
#line hidden
            EndContext();
            BeginContext(579, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(620, 53, false);
#line 27 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.Presiding));

#line default
#line hidden
            EndContext();
            BeginContext(673, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(714, 49, false);
#line 30 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.Presiding));

#line default
#line hidden
            EndContext();
            BeginContext(763, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(804, 58, false);
#line 33 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.FirstHimnTitle));

#line default
#line hidden
            EndContext();
            BeginContext(862, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(903, 54, false);
#line 36 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.FirstHimnTitle));

#line default
#line hidden
            EndContext();
            BeginContext(957, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(998, 56, false);
#line 39 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.FirstHimnNum));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1095, 52, false);
#line 42 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.FirstHimnNum));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1188, 55, false);
#line 45 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.FirstPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1284, 51, false);
#line 48 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.FirstPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1376, 51, false);
#line 51 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1468, 47, false);
#line 54 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1556, 57, false);
#line 57 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.Announcements));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1654, 53, false);
#line 60 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.Announcements));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1748, 56, false);
#line 63 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.FirstSpeaker));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1845, 52, false);
#line 66 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.FirstSpeaker));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1938, 57, false);
#line 69 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.SecondSpeaker));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2036, 53, false);
#line 72 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.SecondSpeaker));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2130, 59, false);
#line 75 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.SecondHimnTitle));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2230, 55, false);
#line 78 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.SecondHimnTitle));

#line default
#line hidden
            EndContext();
            BeginContext(2285, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2326, 57, false);
#line 81 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.SecondHimnNum));

#line default
#line hidden
            EndContext();
            BeginContext(2383, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2424, 53, false);
#line 84 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.SecondHimnNum));

#line default
#line hidden
            EndContext();
            BeginContext(2477, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2518, 56, false);
#line 87 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.ThirdSpeaker));

#line default
#line hidden
            EndContext();
            BeginContext(2574, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2615, 52, false);
#line 90 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.ThirdSpeaker));

#line default
#line hidden
            EndContext();
            BeginContext(2667, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2708, 57, false);
#line 93 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.LastHimnTitle));

#line default
#line hidden
            EndContext();
            BeginContext(2765, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2806, 53, false);
#line 96 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.LastHimnTitle));

#line default
#line hidden
            EndContext();
            BeginContext(2859, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2900, 55, false);
#line 99 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.LastHimnNum));

#line default
#line hidden
            EndContext();
            BeginContext(2955, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2996, 51, false);
#line 102 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.LastHimnNum));

#line default
#line hidden
            EndContext();
            BeginContext(3047, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(3088, 54, false);
#line 105 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Meeting.LastPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(3142, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(3183, 50, false);
#line 108 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Meeting.LastPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(3233, 30, true);
            WriteLiteral("\n        </dd>\n    </dl>\n\n    ");
            EndContext();
            BeginContext(3263, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "917561b23b6a4edfa1b12b76b698f63b", async() => {
                BeginContext(3283, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(3292, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "15aef1135dfe449a9992ab824b0712b2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 113 "C:\Users\FamiliaLezcano\Desktop\Final 2\FinalProject-2.0-master\SacrMeetPlanner\SacrMeetPlanner\Pages\Meetings\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Meeting.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3336, 94, true);
                WriteLiteral("\n        <input type=\"submit\" id=\"deleteButton\" value=\"Delete\" class=\"btn btn-default\" />\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3437, 42, true);
            WriteLiteral("\n    <div class=\"backToListLink\">\n        ");
            EndContext();
            BeginContext(3479, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b4c8ac232f485fa03f57457143c9ac", async() => {
                BeginContext(3501, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3517, 19, true);
            WriteLiteral("\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SacrMeetPlanner.Pages.Meetings.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SacrMeetPlanner.Pages.Meetings.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SacrMeetPlanner.Pages.Meetings.DeleteModel>)PageContext?.ViewData;
        public SacrMeetPlanner.Pages.Meetings.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
