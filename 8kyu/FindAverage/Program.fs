// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let avg list =
        let sum = list |> List.sum
        let res = sum / float(List.length list)
        res
    0 // return an integer exit code
