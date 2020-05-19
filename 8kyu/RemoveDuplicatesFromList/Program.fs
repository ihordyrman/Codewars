// Learn more about F# at http://fsharp.org

open System
open System.Collections.Generic

[<EntryPoint>]
let main argv =
    let distinct list = list |> List.distinct

    let rec anotherDistinct =
        function
        | [] -> []
        | x :: xs -> x :: anotherDistinct (List.filter ((<>) x) xs)

    let oneMoreDistinct list =
        list
        |> List.groupBy id
        |> List.map (fun (key, value) -> key)

    0 // return an integer exit code
