// Matching parttern

let isMatch1 = fun n ->
    match n with
    | 5 -> 10
    | 3 -> 2
    | _ -> 0
    
isMatch1 5 |> printfn "%i"
isMatch1 3 |> printfn "%i"
isMatch1 50 |> printfn "%i"


let isMatch2 = fun n ->
    match n with
    | 20 -> -20
    | 60 -> -60
    | _ -> n
    
isMatch2 20 |> printfn "%i"
isMatch2 60 |> printfn "%i"
isMatch2 50 |> printfn "%i"


let isMatch3 = fun n ->
    match n with
    | x when x % 5 = 0 -> string n + "is multiple 5"
    | x when x % 3 = 0 -> string n + "is multiple 3"
    | _ -> string n
    
isMatch3 0 |> printfn "%s"
isMatch3 5 |> printfn "%s"
isMatch3 3 |> printfn "%s"
isMatch3 15 |> printfn "%s"
isMatch3 22 |> printfn "%s"
isMatch3 -3 |> printfn "%s"