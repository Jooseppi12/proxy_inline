namespace usedproxy

open WebSharper

module What =

    [<SPAEntryPoint>]
    let Main () =
        dotnetlib.MyProp.MyFunction("hola")