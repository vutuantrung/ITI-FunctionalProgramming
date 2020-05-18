let isDividable = 
    fun n -> 
        match n with
        | x when x % 5 = 0 -> string n + " multiple de 5"
        | _ -> string n + " pas multiple de 5"

// With for:
for x in 1..100 do
//    isDividable x |> (printfn "%s")

// With Seq:
[1..100]
    |> Seq.map isDividable
    |> Seq.iter (printfn "%s")

// With recursion:
let rec range = 
    fun n -> 
        (printfn "%s") (isDividable n)
        match n with
        | x when x > 100 -> ()
        | _ -> range (n + 1)

range 1