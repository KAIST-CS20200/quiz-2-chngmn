module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
    let rec iter num temp =
        if num = 1UL then temp
        elif num % 2UL = 0UL then iter (num / 2UL) (temp + 1)
        else iter (3UL * num + 1UL) (temp + 1)

    iter (uint64 n) 0
