let fizzBuzz = fun x ->
    match x with
    | x when x % 5 = 0 && x % 3 = 0 -> "FizzBuzz"
    | x when x % 3 = 0 -> "Fizz"
    | x when x % 5 = 0 -> "Buzz"
    | x -> string x

// With Seq:
let fizzBuzzInRangeSeq = fun range ->
    let min, max = range
    [min..max] 
        |> Seq.map fizzBuzz
        |> Seq.iter (printfn "%s")

fizzBuzzInRangeSeq (20, 80)

// With for:
let fizzBuzzInRangeFor = fun range ->
    let min, max = range
    for x in min..max do
        fizzBuzz x |> (printfn "%s")

fizzBuzzInRangeFor (20, 80)