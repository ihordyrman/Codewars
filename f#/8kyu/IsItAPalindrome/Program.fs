// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let isPalindrom (s: string): bool =
        let (value: string) = s.ToLower()
        let mutable reversedValue = ""
        for i = value.Length - 1 downto 0 do
            reversedValue <- reversedValue + value.[i].ToString()

        value = reversedValue

    let shorterPalindrom (s: string) =
        let arr = s.ToLower().ToCharArray()
        arr = Array.rev arr
    0 // return an integer exit code
