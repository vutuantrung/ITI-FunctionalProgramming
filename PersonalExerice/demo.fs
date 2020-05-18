// demo function

printfn "Demo function"
printfn ""
printfn ""

let printNegative = fun n ->
    match n with
    | x when x >= 0 -> printf "is not negative"
    | _ -> printf "is negative"

let isNegative = fun n -> n > 0
let resultIsNegative = isNegative 20

printfn "%b" resultIsNegative