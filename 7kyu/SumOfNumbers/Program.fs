// Learn more about F# at http://fsharp.org

open System
open System.Collections.Generic

[<EntryPoint>]
let main argv =
    let getSum a b =
        if a > b then seq {b .. a} |> Seq.sum
        elif a < b then seq {a .. b} |> Seq.sum
        else a

    let betterGetSum a b =
        match (a, b) with
        | (a, b) when a > b -> seq {b .. a} |> Seq.sum
        | (a, b) when b > a -> seq {a .. b} |> Seq.sum
        | _ -> a

    let getSumWithLists a b =
        match (a, b) with
        | (a, b) when a > b -> [b..a] |> List.sum
        | (a, b) when b > a -> [a..b] |> List.sum
        | _ -> a

    let shortGetSum a b = [| min a b .. max a b |] |> Array.sum

    printfn "%i" (getSum 1 6)
    printfn "%i" (betterGetSum 1 6)
    printfn "%i" (getSumWithLists 1 6)
    printfn "%i" (shortGetSum 1 6)
    0 // return an integer exit code
