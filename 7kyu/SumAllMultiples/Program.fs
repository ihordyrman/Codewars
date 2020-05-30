// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/57f36495c0bb25ecf50000e7/train/fsharp

// Your task is to write function findSum.
// Upto and including n, this function will return the sum of all multiples of 3 and 5.

open System.Linq

[<EntryPoint>]
let main argv =
    let findSum n =
        Enumerable
            .Range(1, n)
            .Where(fun x -> x % 3 = 0 || x % 5 = 0)
            .Sum()

    let anotherFindSum n =
        [ 3 .. n ]
        |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
        |> List.sum

    let seqFindSum n =
        Seq.sum
            (seq {
                for x in 3 .. n do
                    if (x % 3 = 0 || x % 5 = 0) then yield x
             })

    let cleverFindSum n =
        (seq { 0 .. 3 .. n } |> Seq.sum) +
        (seq { 0 .. 5 .. n } |> Seq.sum) -
        (seq { 0 .. 15 .. n } |> Seq.sum)

    printfn "%i" (findSum 100)
    printfn "%i" (anotherFindSum 100)
    printfn "%i" (seqFindSum 100)
    printfn "%i" (cleverFindSum 100)
    0 // return an integer exit code
