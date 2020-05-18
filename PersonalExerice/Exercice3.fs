// Without tuple
let fizzBuzz = fun n ->
    match n with
    | x when x % 5 = 0 && x % 3 = 0 -> string "FizzBuzz"
    | x when x % 5 = 0 -> string "Buzz"
    | x when x % 3 = 0 -> string "Fizz"
    | _ -> string n
    
// With tuple
let fizzBuzzTuple = fun n ->
    match (n%3, n%5) with
    | 0,0 -> string "FizzBuzz"
    | _,0 -> string "Buzz"
    | 0,_ -> string "Fizz"
    | _ -> string n
    
let testArrayFunc = fun data ->
    let min, max = data
    [min..max]
        |> Seq.map (fizzBuzz)
        |> Seq.iter (printfn "%s")
    
let testForFunc = fun data ->
    let min, max = data
    for i in min..max do
        match i with
        | x when x % 5 = 0 && x % 3 = 0 -> string "FizzBuzz" |> printfn "%s"
        | x when x % 5 = 0 -> string "Buzz" |> printfn "%s"
        | x when x % 3 = 0 -> string "Fizz" |> printfn "%s"
        | _ -> string i |> printfn "%s"
    
let rec resultPrinter = fun data ->
    let min, max = data
    printfn ("%s") (fizzBuzzTuple min)
    match min with
        | x when x > max -> ()
        | _ -> resultPrinter(min + 1, max)