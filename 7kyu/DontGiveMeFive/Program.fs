// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/5813d19765d81c592200001a/train/fsharp
// In this kata you get the start number and the end number of a region and should return
// the count of all numbers except numbers with a 5 in it. The start and the end number are both inclusive!
open System

[<EntryPoint>]
let main argv =
    let dontGiveMeFive startValue endValue =
        match (startValue, endValue) with
        | startValue, endValue when startValue < 5 && endValue > 5 -> Seq.length (seq {startValue .. endValue}) - 1
        | _ -> Seq.length (seq {startValue .. endValue})


    let AnotherDontGiveMeFive startValue endValue =
        {startValue .. endValue}
        |> Seq.sumBy (fun x -> if x.ToString().IndexOf('5') = -1 then 1 else 0)

    printfn "%i" (dontGiveMeFive 1 9)
    printfn "%i" (AnotherDontGiveMeFive 4 17)
    printfn "%i" (AnotherDontGiveMeFive 6 11)
    0 // return an integer exit code
