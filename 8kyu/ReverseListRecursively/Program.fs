// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let NotRecRev list = list |> List.rev

    let rec recRev list =
        match list with
        | [] -> list
        | head :: tail -> recRev tail @ [head]
    0 // return an integer exit code
