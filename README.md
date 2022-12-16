# Horse-AI-
Given a 8*8 board with the Knight placed on the first block of an empty board. Moving according to the rules of chess knight must visit each square exactly once. Print the order of each cell in which they are visited.
Backtracking is an algorithmic paradigm that tries different solutions until finds a solution that “works”. 
Problems that are typically solved using the backtracking technique have the following property in common. 
These problems can only be solved by trying every possible configuration and each configuration is tried only once. 
A Naive solution for these problems is to try all configurations and output a configuration that follows given problem constraints. 
Backtracking works incrementally and is an optimization over the Naive solution where all possible configurations are generated and tried.


If all squares are visited 
    print the solution
Else
   a) Add one of the next moves to solution vector and recursively 
   check if this move leads to a solution. (A Knight can make maximum 
   eight moves. We choose one of the 8 moves in this step).
   b) If the move chosen in the above step doesn't lead to a solution
   then remove this move from the solution vector and try other 
   alternative moves.
   c) If none of the alternatives work then return false (Returning false 
   will remove the previously added item in recursion and if false is 
   returned by the initial call of recursion then "no solution exists" )
   
   note: increase the speed of algorithm
   
   Warnsdorff’s algorithm:

In this approach we can start from any initial square on the chess board. Then, we will move to an adjacent, unvisited square with minimum unvisited adjacent squares.

Algorithm:

    Set a square as the initial position to start from.
    Mark it with current move number starting with "1".
    Make a set of all positions that can be visited from initial position.
    Mark the square out of the set of possible positions that can be visited with minimum accessibility from initial position as next move number.
    Following the above steps, return the marked board with move numbers with which it has been visited.
