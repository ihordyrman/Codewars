// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/5656b6906de340bd1b0000ac
// Take 2 strings s1 and s2 including only letters from ato z.
// Return a new sorted string, the longest possible, containing distinct letters

open System
open System.Linq

[<EntryPoint>]
let main argv =
    let longest (s1: string) (s2: string) =
        Array.append (s1.ToCharArray()) (s2.ToCharArray())
        |> Array.sort
        |> Array.distinct
        |> System.String.Concat

    let shorterLongest (s1: string) (s2: string) =
        s1 + s2
        |> Seq.distinct
        |> Seq.sort
        |> String.Concat

    printfn "%s" (longest "hello" "world")
    printfn "%s" (shorterLongest "hello" "world")
    0 // return an integer exit code
