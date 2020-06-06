// Learn more about F# at http://fsharp.org

// Trolls are attacking your comment section!
// A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
// Your task is to write a function that takes a string and return a new string with all vowels removed.
// For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
// Note: for this kata y isn't considered a vowel.

// https://www.codewars.com/kata/52fba66badcd10859f00097e/train/fsharp

open System

[<EntryPoint>]
let main argv =
    let disemvowel (s: string): string =
        let vovels = [ 'a'; 'e'; 'i'; 'o'; 'u' ]
        s
        |> Seq.filter (fun c -> not (List.contains c vovels))
        |> String.Concat

    let anotherDisemvovel = String.filter(fun x -> not <| "aeiou".Contains(x.ToString().ToLower()))

    printfn "%s" (disemvowel "hello")
    0 // return an integer exit code
