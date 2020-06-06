// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/57a6633153ba33189e000074

// Count the number of occurrences of each character and return it as a list of tuples in order of appearance.
// For empty output return an empty list.
open System

[<EntryPoint>]
let main argv =
    // here I've misunderstood description and made alphabetical number instead of the count of repeating
    let orderedCount text =
        text
        |> Seq.distinct
        |> Seq.map (fun x -> ((x), int x - 96))
        |> Seq.toList

    let correctOrderedCount text =
        text
        |> Seq.countBy id
        |> Seq.toList

    printfn "%A" (orderedCount "abracaabra")
    0 // return an integer exit code
