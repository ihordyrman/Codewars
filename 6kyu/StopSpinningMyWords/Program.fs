// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/5264d2b162488dc400000001/train/fsharp

// Write a function that takes in a string of one or more words, and returns the same string,
// but with all five or more letter words reversed (Just like the name of this Kata).
// Strings passed in will consist of only letters and spaces.
// Spaces will be included only when more than one word is present.

open System
open System.Globalization
open System.Text.RegularExpressions

[<EntryPoint>]
let main argv =
    let spinWords (str : string) =
        let spin =
            function
            | x when Seq.length x >= 5 -> Seq.rev x
            | x -> x

        str.Split " "
        |> Seq.map (spin >> Seq.map (string) >> String.concat "")
        |> String.concat " "

    let reverse (str: string) =
        let a = str.ToCharArray()
        Array.Reverse a
        String a

    let AnotherSpinWords (str: string) =
        Regex.Replace(str, @"\w{5,}", fun x -> reverse x.Value)


    printfn "%s" (spinWords "Hey fellow warriors")
    printfn "%s" (AnotherSpinWords "You are almost to the last test")
    0 // return an integer exit code
