let multiple5 = fun n ->
    match n with
    | x when x % 5 = 0 -> string n + " multiple de 5"
    | _ -> string n + " pas multiple de 5"
    
//[0..100]
    //|> Seq.map multiple5
    //|> Seq.iter(printfn "%s")
    
//for x in 0..10 do
    //multiple5 x |> printfn "%s"
    
let rec testRecrusive = fun n ->
    multiple5 n |> printfn "%s"
    match n with
    | x when x > 20 -> ()
    | _ -> testRecrusive(n + 1)
    
testRecrusive 1