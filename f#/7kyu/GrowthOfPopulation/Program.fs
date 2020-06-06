// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/563b662a59afc2b5120000c6/train/fsharp

// In a small town the population is p0 = 1000 at the beginning of a year.
// The population regularly increases by 2 percent per year and moreover 50 new
// inhabitants per year come to live in the town.
// How many years does the town need to see its population greater or equal to p = 1200 inhabitants?
open System

[<EntryPoint>]
let main argv =
    let nbYear (p0: int) (percent: float) (aug: int) (p: int) =
        let mutable (currentPopulation: int) = p0
        let mutable (year: int) = 0
        while currentPopulation < p do
            currentPopulation <- currentPopulation + int (float currentPopulation * (percent / 100.)) + aug
            year <- year + 1
        year

    let rec betterNbYear (p0: int) (percent: float) (aug: int) (p: int) =
        match (p0, p) with
        | (p0, p) when p0 >= p -> 0
        | _ -> 1 + (betterNbYear (int (float (p0) + float (p0) / 100.0 * percent + float (aug))) percent aug p)

    printfn "%i" (nbYear 1000 2.0 50 1200)
    printfn "%i" (nbYear 1500 5.0 100 5000)
    printfn "%i" (betterNbYear 1500000 2.5 10000 2000000)
    printfn "%i" (betterNbYear 1500000 0.25 1000 2000000)
    0 // return an integer exit code
