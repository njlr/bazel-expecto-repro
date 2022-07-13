open Expecto
open Ratio

let private ratio n d =
  Ratio (n, d)

let tests =
  testList "Ratio" [
    test "+ works for simple cases" {
      Expect.equal (ratio 1 2 + ratio 0 7) (ratio 7 14) ""
      Expect.equal (ratio 1 2 + ratio 3 2) (ratio 4 2) ""
      Expect.equal (ratio 1 3 + ratio 2 2) (ratio 8 6) ""
    }
  ]

[<EntryPoint>]
let main args =
  runTestsWithCLIArgs [] args tests
