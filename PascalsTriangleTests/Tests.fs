module Tests

open FsUnit.Xunit
open Xunit
open Pascals

[<Fact>]
let ``Zero returns empty array`` () =
    0 |> Triangle.build |> should be Empty

[<Theory>]
[<InlineData(1)>]
[<InlineData(2)>]
[<InlineData(3)>]
[<InlineData(4)>]
[<InlineData(5)>]
[<InlineData(10)>]
let ``x returns expected`` rows =
    let expectations = Map.empty
                        .Add(1, [1])
                        .Add(2, [1; 1;1])
                        .Add(3, [1; 1;1; 1;2;1])
                        .Add(4, [1; 1;1; 1;2;1; 1;3;3;1])
                        .Add(5, [1; 1;1; 1;2;1; 1;3;3;1; 1;4;6;4;1])
                        .Add(10,[1; 1;1; 1;2;1; 1;3;3;1; 1;4;6;4;1; 1;5;10;10;5;1; 1;6;15;20;15;6;1; 1;7;21;35;35;21;7;1; 1;8;28;56;70;56;28;8;1; 1;9;36;84;126;126;84;36;9;1])

    let expected = expectations.[rows]
    
    rows |> Triangle.build |> should equal expected