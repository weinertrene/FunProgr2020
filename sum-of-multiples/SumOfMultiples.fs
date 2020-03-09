module SumOfMultiples

let isTeilerVon (teiler: int list) (num: int) : bool =
    let moeglicheTeiler = teiler |> List.filter(fun x -> if x > 0 then num % x = 0 else false)
    not moeglicheTeiler.IsEmpty

let sum (numbers: int list) (upperBound: int): int = 
    [0 .. (upperBound-1)] 
    |> List.filter (isTeilerVon numbers)
    |> List.sum
