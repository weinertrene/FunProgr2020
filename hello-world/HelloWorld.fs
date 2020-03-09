module HelloWorld

let hello: string = "Hello, World!"
let i = 420
let f = 2.3
let b = false
let s = f+(float)i
let t1 = (1,2)
let t2 = (10, 10.0,"alex")
printfn "%s" hello
let list1 = [1;2;3]
let list2 = list1  @ [2;4;5;6]
printfn "%A" list2
List.iteri (fun x i -> printfn "%i" x) list1


let matchint i = match i with | 1 -> 2 | 2 -> 3 | _ -> 3