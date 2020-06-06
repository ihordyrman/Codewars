// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let bmi weight height =
        let bmi = weight / (height * height)
        if bmi <= 18.5 then "Underweight"
        elif bmi <= 25.0 then "Normal"
        elif bmi <= 30. then "Overweight"
        else "Obese"

    let betterBmi weight height =
        let bmi = weight / (height * height)
        match bmi with
        | bmi when bmi <= 18.5 -> "Underweight"
        | bmi when bmi <= 25.0 -> "Normal"
        | bmi when bmi <= 30.0 -> "Overweight"
        | _ -> "Obese"
    0 // return an integer exit code
