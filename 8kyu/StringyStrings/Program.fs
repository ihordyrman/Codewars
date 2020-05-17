// Learn more about F# at http://fsharp.org

open System
open System.Linq

[<EntryPoint>]
let main argv =
    let LinqStringy size =
        String.Join("", Enumerable.Range(0, size).Select(fun x -> (x + 1) % 2))

    let rec RecursiveStringy = function
        | 0 -> ""
        | 1 -> "1"
        | n -> "10" + (RecursiveStringy (n-2))

    let BetterStringy (size:int) =
        [1..size]
        |> List.map (fun (x:int) -> string(x%2))
        |> String.Concat
    0 // return an integer exit code
