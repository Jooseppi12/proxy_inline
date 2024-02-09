module NoNamespace

type prop<'T> =
    static member inline Func(str: 'T) = printfn "%A" str