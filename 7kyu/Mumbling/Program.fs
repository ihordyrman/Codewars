// Learn more about F# at http://fsharp.org

// This time no story, no theory. The examples below show you how to write function accum:
// Examples:
// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"

open System
open System.Linq

[<EntryPoint>]
let main argv =

    let accum (s: string) =
        s.ToLower()
        |> Seq.mapi (fun i c -> (Char.ToUpper c |> string) + (String.replicate i (string c)))
        |> String.concat "-"

    0 // return an integer exit code
