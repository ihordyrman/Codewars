// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let peopleWithAgeDrink (old:int) =
        if (old <= 13) then "drink toddy"
        elif (old <= 17) then "drink coke"
        elif (old <= 20) then "drink beer"
        else "drink whisky"

    let peopleWithAgeDrinkTwo (old: int) =
        match old with
        | x when x <= 13 -> "drink toddy"
        | x when x <= 17 -> "drink coke"
        | x when x <= 20 -> "drink beer"
        | _ -> "drink whisky"

    let (|Children|Teens|Young|Adults|) old =
        if old < 14 then Children
        elif old < 18 then Teens
        elif old < 21 then Young
        else Adults

    let peopleWithAgeDrinkThree old =
        match old with
        | Children -> "drink toddy"
        | Teens -> "drink coke"
        | Young -> "drink beer"
        | Adults -> "drink whisky"
    0 // return an integer exit code
