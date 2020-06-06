// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let rec repeatStr n s =
        if n <= 0 then
            ""
        else
            s + (repeatStr (n-1) s)

    let repeatBetterApproach = String.replicate

    let rec oneMoreApproach n s =
        match n with
        | 0 -> ""
        | _ -> (oneMoreApproach (n-1) s) + s
    0 // return an integer exit code
