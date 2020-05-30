// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/51c7d8268a35b6b8b40002f2/train/fsharp

// Complete the solution so that it takes the object (JavaScript/CoffeeScript) 
// or hash (ruby) passed in and generates a human readable string from its key/value pairs.
// The format should be "KEY = VALUE". Each key/value pair should be separated by a comma except for the last pair.

open System
open System.Collections.Generic
open System.Linq


[<EntryPoint>]
let main argv =
    let solution (dic:IDictionary<'TKey,'TValue>) = 
        String.Join(",", dic.Select(fun x -> String.Format("{0} = {1}", x.Key, x.Value)))

    let anotherSolution (dic: IDictionary<'TKey, 'TValue>) =
        dic
        |> Seq.map (fun x -> sprintf "%A = %A" x.Key x.Value)
        |> String.concat ","

    let data = [
        '^',1
        '&',2
        '$',90
        '1',1300
        '*',8
                  ] |> dict
    
    printf "%s" (solution data)
    printf "%s" (anotherSolution data)
    0 // return an integer exit code
