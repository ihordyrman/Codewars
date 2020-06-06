// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/5663f5305102699bad000056

// You are given two arrays a1 and a2 of strings.
// Each string is composed with letters from a to z.
// Let x be any string in the first array and y be any string in the second array.
// Find max(abs(length(x) − length(y)))
// If a1 and/or a2 are empty return -1 in each language except in Haskell (F#) where you will return Nothing (None).
open System

[<EntryPoint>]
let main argv =
    let mxdiflg(a1: String[]) (a2: String[]): int Option =
        if a1.Length = 0 || a2.Length = 0 then None
        else
            let mutable result = 0
            for i in 0 .. a1.Length - 1 do
                for j in 0 .. a2.Length - 1 do
                    let absolute = abs(a1.[i].Length - a2.[j].Length)
                    if result < absolute then result <- absolute
                    else result <- result

            Some result

    let betterMxdiflg(a1: String[]) (a2: String[]): int Option =
        match a1, a2 with
        | a1, a2 when a1.Length = 0 || a2.Length = 0 -> None
        | _ -> Some ([for x in a1 do
                        for y in a2 -> abs(x.Length - y.Length)] |> List.max)

    let s1 = [|"cccooommaaqqoxii"; "gggqaffhhh"; "tttoowwwmmww"|]
    let s2 = [|"hoqq"; "bbllkw"; "oox"; "ejjuyyy"; "plmiis"; "xxxzgpsssa"; "xxwwkktt"; "znnnnfqknaz"; "qqquuhii"; "dvvvwz"|]
    printfn "%A" (mxdiflg s1 s2)
    printfn "%A" (betterMxdiflg s1 s2)
    0 // return an integer exit code
