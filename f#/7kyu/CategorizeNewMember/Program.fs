// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/5502c9e7b3216ec63c0001aa/train/fsharp

// The Western Suburbs Croquet Club has two categories of membership, Senior and Open.
// They would like your help with an application form that will tell prospective members which category they will be placed.
// To be a senior, a member must be at least 55 years old and have a handicap greater than 7.
// In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
// Input
// Input will consist of a list of lists containing two items each. Each list contains information for a single potential member.
// Information consists of an integer for the person's age and an integer for the person's handicap.
// Note for F#: The input will be of (int list list) which is a List<List>

open System
open System.Collections.Generic

[<EntryPoint>]
let main argv =
    let OpenOrSenior (xs: int list list) =
        xs
        |> List.map (fun x ->
            if x.[0] > 54 && x.[1] > 7 then "Senior" else "Open")

    let AnotherOpenOrSenior = List.map (function
        | [age; handicap] when age > 54 && handicap > 7 -> "Senior"
        | _ -> "Open" )


    printfn "%A"
        (OpenOrSenior
            [ [ 10; 3 ]
              [ 75; 8 ] ])

    printfn "%A"
        (OpenOrSenior
            [ [ 20; 4 ]
              [ 23; 6 ] ])

    printfn "%A"
        (AnotherOpenOrSenior
            [ [ 18; 20 ]
              [ 45; 2 ]
              [ 61; 12 ]
              [ 37; 6 ]
              [ 21; 21 ]
              [ 78; 9 ] ])
    0 // return an integer exit code
