module Isogram

let letters = ['A' .. 'Z']
let isLetter letter =
    letters |> List.contains letter

let uppercase (x : string) = x.ToUpper()

let isIsogram str = 
    let normalStr = str |> uppercase |> Seq.filter isLetter |> Seq.toList 
    let newStr =
        str
        |> uppercase
        |> Seq.filter isLetter
        |> Seq.distinct
        |> Seq.toList
    newStr.Length = normalStr.Length

    //Seq.distinct str 
    
 
let s = isLetter '0'
//let x = isIsogram 
//printfn "%A" x