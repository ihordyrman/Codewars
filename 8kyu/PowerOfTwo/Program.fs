// Learn more about F# at http://fsharp.org

open System.Linq

[<EntryPoint>]
let main argv =
    // let powersOfTwo n = Enumerable.Range(0, n+1).Select(fun x -> pown 2 x).ToArray |> List.map
    let powersOfTwo n = [ for i in 0 .. n -> 1 <<< i ]
    let anotherPowersOfTwo n = List.map (fun x -> pown 2 x) [0..n]
    0 // return an integer exit code
