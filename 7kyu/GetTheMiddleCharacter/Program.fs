// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let getMiddle (str: string) =
        match str.Length with
        | 0 -> ""
        | x when x % 2 = 0 -> String.Concat(str.[(str.Length / 2) - 1], str.[str.Length / 2])
        | x when x % 2 <> 0 -> string str.[str.Length / 2]
        | _ -> ""

    let BetterGetMiddle (str: string) =
        let len = str.Length
        match len % 2 with
        | 0 -> str.[len/2-1 .. len/2]
        | _ -> str.[len/2].ToString()

    printfn "%s" (getMiddle "test")
    printfn "%s" (getMiddle "testing")
    printfn "%s" (getMiddle "middle")
    printfn "%s" (getMiddle "A")
    0 // return an integer exit code
