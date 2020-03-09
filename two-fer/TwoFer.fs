module TwoFer

let exists (x : int option) =
    match x with
    | Some(x) -> true
    | None -> false

let twoFer (input: string option): string = 
    match input with 
    | Some(name) -> "One for " + name + ", one for me."
    | None ->  "One for you, one for me."