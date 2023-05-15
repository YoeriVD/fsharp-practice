module Program


open Bmi

[<EntryPoint>]
let rec promptUser args =
    printfn "Enter your weight in kilograms: "
    let weight = System.Console.ReadLine() |> float
    printfn "Enter your height in meters: "
    let height = System.Console.ReadLine() |> float
    bmi weight height |> printBmi
    printfn "Would you like to calculate another BMI? (y/n)"
    let response = System.Console.ReadLine()
    if response = "y" then promptUser args
    else 0 // exit code
