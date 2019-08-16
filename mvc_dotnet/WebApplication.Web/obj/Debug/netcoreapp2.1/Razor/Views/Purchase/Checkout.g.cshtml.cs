#pragma checksum "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf250c50e8e48e948f74773a8fc60b9d827f6e95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_Checkout), @"mvc.1.0.view", @"/Views/Purchase/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Purchase/Checkout.cshtml", typeof(AspNetCore.Views_Purchase_Checkout))]
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
#line 1 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web;

#line default
#line hidden
#line 2 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf250c50e8e48e948f74773a8fc60b9d827f6e95", @"/Views/Purchase/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b9b07c050a0c51332b819e62acfb82d2ccb8e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurchaseFlowVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    // Set discount rates for Children and Senior Citizens
    //decimal kidsDiscount = (decimal)0.60;
    //decimal seniorDiscount = (decimal)0.90;

    //// Set ticket prices based off the regular ticket price for the selected showing
    //decimal priceOfRegularTickets = Model.RegularTicketPrice;
    //decimal priceOfKidsTickets = Model.RegularTicketPrice * kidsDiscount;
    //decimal priceOfSeniorTickets = Model.RegularTicketPrice * seniorDiscount;

    // Calculate the subtotals for each type of ticket, to be displayed below
    decimal totalCostOfRegularTickets = Model.RegularTicketPrice * Model.RegularSeats;
    decimal totalCostOfKidsTickets = Model.KidsTicketPrice * Model.KidsSeats;
    decimal totalCostOfSeniorTickets = Model.SeniorTicketPrice * Model.SeniorSeats;

#line default
#line hidden
            BeginContext(865, 4681, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e47b45e4e446febf77372fdf9ff63b", async() => {
                BeginContext(933, 394, true);
                WriteLiteral(@"
    <h2>Checkout</h2>
    <table class=""table table-striped table-bordered"">
        <thead>
            <tr>
                <th>Ticket type</th>
                <th>Quantity</th>
                <th>Price per</th>
                <th>Subtotal</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Regular tickets</td>
                <td>");
                EndContext();
                BeginContext(1328, 18, false);
#line 32 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
               Write(Model.RegularSeats);

#line default
#line hidden
                EndContext();
                BeginContext(1346, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1375, 38, false);
#line 33 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
                Write(Model.RegularTicketPrice.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(1414, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1443, 39, false);
#line 34 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
                Write(totalCostOfRegularTickets.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(1483, 109, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Children\'s tickets</td>\r\n                <td>");
                EndContext();
                BeginContext(1593, 15, false);
#line 38 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
               Write(Model.KidsSeats);

#line default
#line hidden
                EndContext();
                BeginContext(1608, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1637, 35, false);
#line 39 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
                Write(Model.KidsTicketPrice.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(1673, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1702, 38, false);
#line 40 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
                Write((totalCostOfKidsTickets).ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(1741, 115, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Senior Citizen\'s tickets</td>\r\n                <td>");
                EndContext();
                BeginContext(1857, 17, false);
#line 44 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
               Write(Model.SeniorSeats);

#line default
#line hidden
                EndContext();
                BeginContext(1874, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1903, 37, false);
#line 45 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
                Write(Model.SeniorTicketPrice.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(1941, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1970, 40, false);
#line 46 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
                Write((totalCostOfSeniorTickets).ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(2011, 169, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Cuyahoga County tax (7%)</td>\r\n                <td></td>\r\n                <td></td>\r\n                <td>");
                EndContext();
                BeginContext(2182, 111, false);
#line 52 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
                Write(((decimal)0.07 * (totalCostOfKidsTickets + totalCostOfRegularTickets + totalCostOfSeniorTickets)).ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(2294, 156, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Grand Total</td>\r\n                <td></td>\r\n                <td></td>\r\n                <td>");
                EndContext();
                BeginContext(2452, 111, false);
#line 58 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
                Write(((decimal)1.07 * (totalCostOfKidsTickets + totalCostOfRegularTickets + totalCostOfSeniorTickets)).ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(2564, 44, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n");
                EndContext();
#line 61 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
                  
                    string ticketListString = "";
                    if (Model.ChosenSeats.Count == 0)
                    {
                        Model.ChosenSeats.Add(1);
                        Model.ChosenSeats.Add(2);
                        Model.ChosenSeats.Add(3);
                    }
                    foreach (int ticket in Model.ChosenSeats)
                    {
                        ticketListString += ", ";
                        ticketListString += ticket;
                    }
                    ticketListString = ticketListString.Substring(2);
                

#line default
#line hidden
                BeginContext(3236, 56, true);
                WriteLiteral("                <td>You selected the following tickets: ");
                EndContext();
                BeginContext(3293, 16, false);
#line 76 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
                                                   Write(ticketListString);

#line default
#line hidden
                EndContext();
                BeginContext(3309, 277, true);
                WriteLiteral(@"</td>
            </tr>
        </tbody>
    </table>
    <div class=""billing-info"">
        <h2>Please enter payment information</h2>
        <div class=""form-group"">
            <label for=""firstName"">First Name</label>
            <input type=""text"" name=""firstName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3586, "\"", 3622, 1);
#line 84 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
WriteAttributeValue("", 3594, Model.CurrentUser.FirstName, 3594, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3623, 191, true);
                WriteLiteral(" class=\"form-control form-control-sm\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"lastName\">Last Name</label>\r\n            <input type=\"text\" name=\"lastName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3814, "\"", 3849, 1);
#line 88 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
WriteAttributeValue("", 3822, Model.CurrentUser.LastName, 3822, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3850, 187, true);
                WriteLiteral(" class=\"form-control form-control-sm\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"address\">Address</label>\r\n            <input type=\"text\" name=\"address\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4037, "\"", 4071, 1);
#line 92 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
WriteAttributeValue("", 4045, Model.CurrentUser.Address, 4045, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4072, 178, true);
                WriteLiteral(" class=\"form-control form-control-sm\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"city\">City</label>\r\n            <input type=\"text\" name=\"city\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4250, "\"", 4281, 1);
#line 96 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
WriteAttributeValue("", 4258, Model.CurrentUser.City, 4258, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4282, 181, true);
                WriteLiteral(" class=\"form-control form-control-sm\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"state\">State</label>\r\n            <input type=\"text\" name=\"state\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4463, "\"", 4495, 1);
#line 100 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
WriteAttributeValue("", 4471, Model.CurrentUser.State, 4471, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4496, 180, true);
                WriteLiteral(" class=\"form-control form-control-sm\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"zip\">Zip Code</label>\r\n            <input type=\"text\" name=\"zip\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4676, "\"", 4706, 1);
#line 104 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
WriteAttributeValue("", 4684, Model.CurrentUser.Zip, 4684, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4707, 181, true);
                WriteLiteral(" class=\"form-control form-control-sm\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"email\">Email</label>\r\n            <input type=\"text\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4888, "\"", 4920, 1);
#line 108 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
WriteAttributeValue("", 4896, Model.CurrentUser.Email, 4896, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4921, 66, true);
                WriteLiteral(" class=\"form-control form-control-sm\" />\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(4987, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "750e8d3f2da64f2db904dcf8be599ced", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 110 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ShowTimeID);

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
                BeginContext(5031, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(5041, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ca126255cc74a1d9525f12787217271", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 111 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RegularTicketPrice);

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
                BeginContext(5093, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(5103, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a315817f8804d74ab0dcdb83e9a1c01", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 112 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RegularSeats);

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
                BeginContext(5149, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(5159, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a3b719de4bb4c738cbc1abba2d1fb0d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 113 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.KidsSeats);

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
                BeginContext(5202, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(5212, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e02a89a932b04eccb8a09ad5ca40030f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 114 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SeniorSeats);

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
                BeginContext(5257, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
                BeginContext(5269, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09655a0ae4cc46bab807e655e4f7ce35", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 116 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MovieDate);

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
                BeginContext(5312, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(5322, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1fd851836e2e4f6abdf6056f5a3c39a7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 117 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ChosenSeatsAsString);

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
                BeginContext(5375, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(5385, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0cb9e55f6ae45d28bc77f3467d7c2d1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 118 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Purchase\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilmName);

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
                BeginContext(5427, 112, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Purchase\" class=\"btn account-btn btn-primary btn-block\" />\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PurchaseFlowVM> Html { get; private set; }
    }
}
#pragma warning restore 1591