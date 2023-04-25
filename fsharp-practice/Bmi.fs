module Bmi

open MathPipes

let calculateBmi weight height =
    weight
    |> divideBy (height * height)
    |> roundByOne
    

let evaluateBmi bmi =
    match bmi with
    | bmiValue when bmiValue < 18.5 -> "Ondergewicht"
    | bmiValue when bmiValue >= 18.5 && bmiValue <= 24.9 -> "Normaal"
    | bmiValue when bmiValue >= 25.0 && bmiValue <= 29.9 -> "Overgewicht"
    | _ -> "Gezondheidsrisico"
    
let bmi weight heigth = calculateBmi weight heigth |> evaluateBmi