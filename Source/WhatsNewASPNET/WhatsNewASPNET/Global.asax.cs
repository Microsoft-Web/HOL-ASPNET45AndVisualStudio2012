using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
//using Microsoft.Web.Optimization;

namespace Web11
{
    public class Global : System.Web.HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Default behavior
            // Bundles all .js files in folders such as "scripts" if URL pointed to it: http://localhost:54716/scripts/custom/js
            //BundleTable.Bundles.EnableDefaultBundles();

            //// Static bundle.
            //// Access on url http://localhost:54716/StaticBundle
            //Bundle b = new Bundle("~/StaticBundle", typeof(JsMinify));
            //b.AddFile("~/scripts/custom/ECMAScript5.js");
            //b.AddFile("~/scripts/custom/GoToDefinition.js");
            //b.AddFile("~/scripts/bundle/JScript1.js");
            //b.AddFile("~/scripts/bundle/JScript2.js");

            //BundleTable.Bundles.Add(b);

            //// Dynamic bundle
            //// Bundles all .coffee files in folders such as "script" when "coffee" is appended to it: http://localhost:54716/scripts/coffee
            //DynamicFolderBundle fb = new DynamicFolderBundle("coffee", typeof(CoffeeMinify), "*.coffee");
            //BundleTable.Bundles.Add(fb);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
