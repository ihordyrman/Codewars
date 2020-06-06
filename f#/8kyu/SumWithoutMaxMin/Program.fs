// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let sumArray array =
       match array with
       | None
       | Some [] -> 0
       | Some [x] -> 0
       | Some values -> (List.sum values) - (List.max values) - (List.min values)
    0 // return an integer exit code
