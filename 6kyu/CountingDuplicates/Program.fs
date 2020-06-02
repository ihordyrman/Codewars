// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/fsharp

// Write a function that will return the count of distinct case-insensitive alphabetic characters
// and numeric digits that occur more than once in the input string.
// The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
open System.Linq

[<EntryPoint>]
let main argv =
    let duplicateCount (text : string) =
        text.ToLower().GroupBy(fun x -> x).Count(fun y -> y.Count() > 1);

    let betterDuplicateCount (text: string) =
        text.ToLower()
        |> Seq.countBy id
        |> Seq.filter (snd >> ((<)1))
        |> Seq.length

    0 // return an integer exit code
