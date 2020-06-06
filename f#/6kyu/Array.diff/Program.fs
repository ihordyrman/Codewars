// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/523f5d21c841566fde000009/train/fsharp

// Your goal in this kata is to implement a difference function,
// which subtracts one list from another and returns the result.
// It should remove all values from list a, which are present in list b.
open System

[<EntryPoint>]
let main argv =
    let arrayDiff (itemsToExclude: int[]) (source:int[]) =
        source |> Array.filter (fun x -> not (Array.contains x itemsToExclude))

    let anotherArrayDiff itemsToExclude source =
        let itemsToExclude = itemsToExclude |> Set.ofArray
        source
        |> Array.choose (fun x -> if itemsToExclude.Contains x then None else Some x)

    printfn "%A" (arrayDiff [|1; 1; 1|] [|1; 2|])
    printfn "%A" (anotherArrayDiff [|1; 1; 1|] [|1; 2|])
    0 // return an integer exit code
