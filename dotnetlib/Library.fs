namespace dotnetlib

type MyProp =
    inherit NoNamespace.prop<string>

    static member inline MyFunction(str: string) = printfn "MyFunction: %A" str
