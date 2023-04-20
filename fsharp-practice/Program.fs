module Program

open System
open Math
open Input
open Output

let bmi (length: decimal) (weigth: decimal) : decimal =
    let lengthForBmi = length |> devideBy 100m |> square
    weigth |> devideBy lengthForBmi

let length = readLength () |> parseString
$"You entered {length}cm" |> Console.WriteLine
let weigth = readWeigth () |> parseString
$"You entered {weigth}kg" |> Console.WriteLine

let result = bmi length weigth
$"Your BMI is %0.2f{result}" |> print
