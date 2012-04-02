using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.Optimization;

namespace Web11
{
    public class CoffeeMinify : JsMinify
    {
        public CoffeeMinify() 
        { 
        }

        public override void Process(BundleResponse bundle)
        {
            // Write coffee compiler calls here
            // pass bundle.Files to it
            // replace bundle.Files with the output of Coffee Compiler  
            // now pass it to JS Minify
            base.Process(bundle);
        }
    }
}