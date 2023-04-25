module MathPipes


let divideBy (by:float) (number:float)  =
    number /  by

let roundBy (by: int) (number: float) =
    System.Math.Round(number, by)
    
let roundByOne = roundBy 1


let powerBy x y = y ** x
let square x = x |> powerBy 2.