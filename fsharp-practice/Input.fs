module Input

open System
let readLength _ =
        printfn "What is your length in cm?"
        Console.ReadLine()

let readWeigth _ =
        printfn "What is your weight in kg?"
        Console.ReadLine()

let parseString (a: string) : decimal = Decimal.Parse a