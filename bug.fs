let mutable x = 10
let y = &x

let mutable z = 20

y <- &z

printf "%d %d" x (!y)
(*Output: 20 20*)