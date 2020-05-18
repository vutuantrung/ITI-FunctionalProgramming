let fizzBuzz = fun x ->
    match x with
    | x when x % 5 = 0 && x % 3 = 0 -> "FizzBuzz"
    | x when x % 3 = 0 -> "Fizz"
    | x when x % 5 = 0 -> "Buzz"
    | x -> string x

let fizzBuzzInRange = fun min -> fun max ->
    for x in min..max do
        fizzBuzz x |> (printfn "%s")

// Full Application:
fizzBuzzInRange 55 60

// Partial Application:
let fizzBuzzFrom20 = fizzBuzzInRange 20
fizzBuzzFrom20 25