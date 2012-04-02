/// <reference path="JScript1.js" />
/// <reference path="JScript2.js" />
function foo3(param1, param2) {
    /// <summary>foo3 function</summary>
    /// <param name="param1" type="String">This is p1</param>
    /// <param name="param2" type="String">This is p2</param>
    var myObject = {
        bar: /* block comments too! */function () {
            return this;
        }
    };
}

