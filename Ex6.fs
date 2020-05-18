type List<'T> =
    | Empty
    | Item of 'T * List<'T>
    
let add = fun item -> fun list ->
    Item(item, list)
    
let rec addLast = fun item -> fun list ->
    match list with
    | Item (head, tail) -> Item(head, addLast item tail)
    | Empty -> Item(item, Empty)

let rec printList = fun list -> 
    match list with
    | Item (value, tail) -> printf "%s " (value.ToString()); printList tail
    | Empty -> printfn ""