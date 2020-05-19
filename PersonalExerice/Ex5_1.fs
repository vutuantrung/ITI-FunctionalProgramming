// Result type
type RuleResult =
    | Fail
    | Success of string

// Rules
let isPrime = fun n ->
    [2 .. (n |> float |> sqrt |> int)]
        |> Seq.forall (fun x -> n % x <> 0)
    
let fizzRule = fun n ->
    match n with
    | x when x % 3 = 0 -> Success("Fizz")
    | _ -> Fail
     
let buzzRule = fun n ->
    match n with
    | x when x % 5 = 0 -> Success("Buzz")
    | _ -> Fail

let fizzBuzzRule = fun n ->
    match n with
    | x when x % 5 = 0 && x % 3 = 0 -> Success("FizzBuzz")
    | _ -> Fail

let tarRule = fun n ->
    match n with
    | x when isPrime x -> Success("Tar")
    | _ -> Fail  
    
let rules = [ fizzRule; buzzRule; tarRule ]

// Apply rules function
let applyRules = fun rules -> fun n ->
    let rec checkRules' = fun rulesList ->
        match rulesList with
        | [] -> Fail
        | head :: tail ->
            match head n with
            | Success _ as s -> s
            | Fail -> checkRules' tail

    match checkRules' rules with
    | Success s -> s
    | Fail -> string n

let fizzBuzz = fun rules -> fun min -> fun max ->
    [min..max]
        |> Seq.map (applyRules rules)
        |> Seq.iter (printfn "%s")

fizzBuzz [ fizzBuzzRule; fizzRule; buzzRule; tarRule ] 20 80