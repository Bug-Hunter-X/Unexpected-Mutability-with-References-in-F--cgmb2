# Unexpected Mutability with References in F#

This example demonstrates a common pitfall in F# when working with mutable references.  The issue arises from the way references are handled and how changes propagate.

**Problem:**
The code uses mutable references (`&`).  When the reference `y` is reassigned to point to `z`, changes to the value pointed to by `y` also affect the original variable `x` because the reference is passed by reference.  This unintended side-effect can be difficult to debug, especially in larger programs.

**Solution:**
Consider the use of immutable data structures or functional programming techniques whenever possible.  In cases where mutability is essential, carefully manage references to avoid unintended consequences.  The bug solution shows more careful handling of mutable references where the values are properly managed avoiding unexpected mutability.