﻿// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/56541980fa08ab47a0000040/train/fsharp

// In a factory a printer prints labels for boxes.
// For one kind of boxes the printer has to use colors which, for the sake of simplicity, are named with letters from a to m.
// The colors used by the printer are recorded in a control string.
// For example a "good" control string would be aaabbbbhaijjjm meaning that the printer used three times color a,
// four times color b, one time color h then one time color a...
// Sometimes there are problems: lack of colors, technical malfunction
// and a "bad" control string is produced e.g. aaaxbbbbyyhwawiwjjjwwm with letters not from a to m.
// You have to write a function printer_error which given a string will output the error rate of the printer
// as a string representing a rational whose numerator is the number of errors and the denominator the length of the control string.
// Don't reduce this fraction to a simpler expression.
// The string has a length greater or equal to one and contains only letters from ato z.
open System
open System.Linq

[<EntryPoint>]
let main argv =
    let printerError (s: string) =
        String.Format("{0}/{1}", s.Count(fun x -> (int x < 97) || (int x > 109)), s.Length)

    let betterPrinterError (s: string) =
        sprintf "%d/%d"
            (s
             |> Seq.sumBy (fun x ->
                 if x > 'm' then 1 else 0)) s.Length

    printfn "%s" (printerError "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz")
    printfn "%s" (betterPrinterError "kkkwwwaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyzuuuuu")
    printfn "%s" (betterPrinterError "kkkwwwaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz")
    0 // return an integer exit code
