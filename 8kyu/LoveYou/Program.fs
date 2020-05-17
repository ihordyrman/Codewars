// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let howMuchILoveYou (nbPetals:int) =
        let flower = nbPetals % 6
        match flower with
        | 5 -> "madly"
        | 4 -> "passionately"
        | 3 -> "a lot"
        | 2 -> "a little"
        | 1 -> "I love you"
        | _ -> "not at all"
    0 // return an integer exit code
