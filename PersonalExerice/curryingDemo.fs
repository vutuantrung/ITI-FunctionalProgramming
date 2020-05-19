let add = fun x ->
    let add' = fun y -> x + y
    add'
    
let result1 = add (5) (20)

printfn "%i" result1


let add5 = add (5)
let result2 = add5 10

printfn "%i" result2

let addTest2 = fun x -> fun y ->
    x + y
    
printfn "%i" (addTest2 20 30)