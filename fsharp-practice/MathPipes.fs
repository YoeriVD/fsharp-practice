module MathPipes


let divideBy (by:float) (number:float)  =
    number /  by

let roundBy (by: int) (number: float) =
    System.Math.Round(number, by)