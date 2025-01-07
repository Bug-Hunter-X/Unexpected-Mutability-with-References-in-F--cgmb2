let mutable x = 10
let mutable y = x //Direct assignment instead of reference

let mutable z = 20

y <- z //Assigning value directly

printf "%d %d" x y
(*Output: 10 20*)

//Alternatively, use copy-on-write approach for better managing references
let xRef = ref 10
let yRef = ref (!xRef)
let zRef = ref 20

 yRef := !zRef
printf "%d %d %d" !xRef !yRef !zRef
(*Output: 10 20 20*) 