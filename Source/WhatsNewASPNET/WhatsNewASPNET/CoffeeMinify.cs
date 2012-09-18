﻿namespace Web11
{
    using CoffeeSharp;
    using Microsoft.Web.Optimization;

    public class CoffeeMinify : JsMinify
    {
        public override void Process(BundleResponse bundle)
        {
            var compiler = new CoffeeScriptEngine();
            bundle.Content = compiler.Compile(bundle.Content);

            base.Process(bundle);
        }
    }
}