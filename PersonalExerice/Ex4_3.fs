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
    
let rec resultPrinter = fun min -> fun max ->
    printfn ("%s") (fizzBuzzTuple min)
    match min with
        | x when x > max -> ()
        | _ -> resultPrinter (min + 1) ( max)
        
let fizzBuzzFrom20 = resultPrinter 20
let fizzBuzzTo50 = fizzBuzzFrom20 50