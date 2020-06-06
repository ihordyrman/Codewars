// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/5506b230a11c0aeab3000c1f/train/fsharp

// This program tests the life of an evaporator containing a gas.
// We know the content of the evaporator (content in ml), the percentage of foam or gas lost every day
// (evap_per_day) and the threshold (threshold) in percentage beyond which the evaporator is no longer useful.
// All numbers are strictly positive.

// The program reports the nth day (as an integer) on which the evaporator will be out of use.
open System

[<EntryPoint>]
let main argv =
    let evaporator (content: double) (evapPerDay: double) (threshold: double): int =
        let mutable days = 0
        let mutable sprayContent = 100.
        while sprayContent > threshold do
            days <- days + 1
            sprayContent <- sprayContent - (sprayContent * evapPerDay * 0.01)
        days

    let BetterEvaporator _ (evapPerDay: double) (threshold: double): int =
        int (ceil (log (threshold / 100.0) / log (1.0 - evapPerDay / 100.0)))

    let anotherEvaporator (content: double) (evapPerDay: double) (threshold: double): int =
        let _thresh = content * threshold / 100.
        let _evap = 1. - (evapPerDay / 100.)
        log (_thresh / content) / log _evap
        |> ceil
        |> int

    printfn "%i" (evaporator 10.0 10.0 10.0)
    printfn "%i" (evaporator 10.0 10.0 5.0)
    printfn "%i" (BetterEvaporator 100.0 5.0 5.0)
    printfn "%i" (anotherEvaporator 50.0 12.0 1.0)
    0 // return an integer exit code
