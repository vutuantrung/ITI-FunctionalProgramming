let rec sumUntil = fun n ->
    match n with
    | x when x = 0 -> 0
    | x -> n + sumUntil(n-1)
    
let resultSumUntil = sumUntil 12

printfn "%i" resultSumUntil