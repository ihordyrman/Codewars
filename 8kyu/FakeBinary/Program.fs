// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let fakeBin = String.map (fun x -> if x < '5' then '0' else '1')
    let anotherFakeBin = String.collect (fun c -> if c  < '5' then "0" else "1")

    let asInt (char: char) = int char - int '0'
    let isGreaterThan4 (x: int) = x > 4
    let toChar (x: bool) =
        match x with
        | false -> '0'
        | true -> '1'

    let cleverFakeBin x =
        x
        |> Seq.toArray
        |> Array.map (asInt >> isGreaterThan4 >> toChar)
        |> System.String

    printfn "%s" (cleverFakeBin "3615125")
    printfn "%s" (anotherFakeBin "3615125")
    printfn "%s" (fakeBin "3615125")
    0 // return an integer exit code
