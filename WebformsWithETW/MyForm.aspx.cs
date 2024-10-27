using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformsWithETW
{
    public partial class MyForm : System.Web.UI.Page
    {

        private void Page_PreInit(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_PreInit), "", this.GetHashCode());
        }

        private void Page_Init(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_Init), "", this.GetHashCode());
        }

        private void Page_InitComplete(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_InitComplete), "", this.GetHashCode());
        }

        private void Page_PreLoad(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_PreLoad), "", this.GetHashCode());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_Load), "", this.GetHashCode());
        }

        private void Page_LoadComplete(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_LoadComplete), "", this.GetHashCode());
        }

        private void Page_PreRender(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_PreRender), "", this.GetHashCode());
        }

        private void Page_PreRenderComplete(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_PreRenderComplete), "", this.GetHashCode());
        }

        private void Page_SaveStateComplete(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_SaveStateComplete), "", this.GetHashCode());
        }

        protected override void Render(HtmlTextWriter writer)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Render), "Start", this.GetHashCode());
            base.Render(writer);
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Render), "End", this.GetHashCode());
        }

        protected override void RenderChildren(HtmlTextWriter writer)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(RenderChildren), "Start", this.GetHashCode());
            base.RenderChildren(writer);
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(RenderChildren), "End", this.GetHashCode());
        }

        private void Page_Unload(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_Unload), "", this.GetHashCode());
        }

        // below events did not get called

        private void Page_AbortTransaction(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_AbortTransaction), "", this.GetHashCode());
        }

        private void Page_CommitTransaction(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_CommitTransaction), "", this.GetHashCode());
        }

        private void Page_DataBinding(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_DataBinding), "", this.GetHashCode());
        }

        private void Page_Disposed(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_Disposed), "", this.GetHashCode());
        }

        private void Page_Error(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyForm), nameof(Page_Error), "", this.GetHashCode());
        }

    }
}