// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let maps (x:int[]) = x |> Array.map (fun z -> z * 2)
    let betterMaps (x:int[]) = Array.map((*) 2)
    0 // return an integer exit code
