using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformsWithETW
{
    public partial class MyControl : System.Web.UI.UserControl
    {

        private void Page_Init(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_Init), "", this.GetHashCode());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_Load), "", this.GetHashCode());
        }

        private void Page_PreRender(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_PreRender), "", this.GetHashCode());
        }

        protected override void Render(HtmlTextWriter writer)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Render), "Start", this.GetHashCode());
            base.Render(writer);
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Render), "End", this.GetHashCode());
        }

        protected override void RenderChildren(HtmlTextWriter writer)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(RenderChildren), "Start", this.GetHashCode());
            base.RenderChildren(writer);
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(RenderChildren), "End", this.GetHashCode());
        }

        private void Page_Unload(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_Unload), "", this.GetHashCode());
        }

        // below events did not get called

        private void Page_SaveStateComplete(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_SaveStateComplete), "", this.GetHashCode());
        }

        private void Page_PreRenderComplete(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_PreRenderComplete), "", this.GetHashCode());
        }

        private void Page_PreLoad(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_PreLoad), "", this.GetHashCode());
        }

        private void Page_PreInit(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_PreInit), "", this.GetHashCode());
        }

        private void Page_LoadComplete(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_LoadComplete), "", this.GetHashCode());
        }

        private void Page_InitComplete(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_InitComplete), "", this.GetHashCode());
        }

        private void Page_Error(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_Error), "", this.GetHashCode());
        }

        private void Page_Disposed(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_Disposed), "", this.GetHashCode());
        }

        private void Page_DataBinding(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_DataBinding), "", this.GetHashCode());
        }

        private void Page_CommitTransaction(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_CommitTransaction), "", this.GetHashCode());
        }

        private void Page_AbortTransaction(object sender, EventArgs e)
        {
            MyAppPerformance.Log.Perf(nameof(MyControl), nameof(Page_AbortTransaction), "", this.GetHashCode());
        }

    }
}