// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/53dbd5315a3c69eed20002dd/fsharp
// In this kata you will create a function that takes a list of non-negative integers
// and strings and returns a new list with the strings filtered out.

// Example
// filter_list([1,2,'a','b']) == [1,2]
// filter_list([1,'a','b',0,15]) == [1,0,15]
// filter_list([1,2,'aasf','1','123',123]) == [1,2,123]


open System

[<EntryPoint>]
let main argv =
    let GetIntegersFromList (listOfItems: Object list) =
        let fil = fun x -> box x :? int
        listOfItems
        |> List.filter (fun x -> fil x)
        |> List.map unbox

    let anotherGetIntegersFromList: obj list -> int list =
        List.filter (function
            | :? int as n -> true
            | _ -> false)
        >> List.map unbox

    let BestGetIntegersFromList (xs: obj list) = xs |> List.choose tryUnbox<int>
    0 // return an integer exit code
