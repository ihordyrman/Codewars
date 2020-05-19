// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let checkForFactor b f = b % f = 0

    let matchCheckFactor b f =
        match f with
        | 0 -> false
        | _ -> b % f = 0
    0 // return an integer exit code
