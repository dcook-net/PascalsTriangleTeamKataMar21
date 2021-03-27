namespace Pascals

module Triangle =
    
    let private buildNewRow triangle previousRowNumber =
        let row = triangle
                    |> List.rev
                    |> List.take(previousRowNumber)
                    |> List.pairwise
                    |> List.fold (fun row (prev:int, current:int) -> row @ [prev + current]) [1]
                
        triangle @ row @ [1]

    let private buildTriangle rows =
        [2 .. rows-1]
        |> List.fold buildNewRow [1;1;1]

    let build rows =
        match rows with
        | x when x <= 0 -> []
        | 1 -> [1]
        | 2 -> [1;1;1]
        | _ -> buildTriangle rows
