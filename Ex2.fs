// Without tuples:
[1..100] 
    |> Seq.map (fun x ->
        match x with
        | x when x % 5 = 0 && x % 3 = 0 -> "FizzBuzz"
        | x when x % 3 = 0 -> "Fizz"
        | x when x % 5 = 0 -> "Buzz"
        | x -> string x)
    |> Seq.iter (printfn "%s")

// With tuples:
[1..100] 
    |> Seq.map (fun n ->
        match (n%3, n%5) with
        | 0, 0 -> "FizzBuzz"
        | 0, _ -> "Fizz"
        | _, 0 -> "Buzz"
        | _ -> string n)
    |> Seq.iter (printfn "%s")

// With function:
let fizzBuzz = fun x ->
    match x with
    | x when x % 5 = 0 && x % 3 = 0 -> "FizzBuzz"
    | x when x % 3 = 0 -> "Fizz"
    | x when x % 5 = 0 -> "Buzz"
    | x -> string x

[1..100] 
    |> Seq.map fizzBuzz
    |> Seq.iter (printfn "%s")