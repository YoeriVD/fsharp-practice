module ProgramTests

open Xunit
open Program

let bmiData _ =
    [|
        [| 82m; 175m; 26.8m |]
        [| 82m; 175m; 26.8m |]
    |]


[<Theory; MemberData("bmiData")>]
let ``BMI should calculate weight in kg / (length in cm ^ 2)`` (weigth: decimal) (length: decimal) expected =
    let result = bmi weigth length
    Assert.Equal(expected, result)
