﻿Priority
Our website receives visitors from 3 locations and the number of unique visitors from each of them is represented by three integers a, b and c.
Considering our servers cannot serve more than N visitors, which is always less than the total number of users from all three locations
Your task is to
write a function that prints to the standard output (stdout) the number of unique possible configurations (as, bs, cs) which can be used to serve exactly N visitors
as represents the number of users from location a we choose to serve
bs represents the number of users from location b we choose to serve
cs represents the number of users from location c we choose to serve
Note that your function will receive the following arguments:
a
which is an integer representing the number of users from location a
b
which is an integer representing the number of users from location b
c
which is an integer representing the number of users from location c
n
which is an integer representing the number of users our servers can serve
Data constraints
the values for a, b, c will be in the [0 .. 100] range
n will always be smaller than the sum of a, b, and c
Example
Input	Output
a: 1
b: 1
c: 1
n: 2
3
a: 2
b: 2
c: 2
n: 2
6
Explanation
The possible configurations for the second example are: (1, 1, 0), (1, 0, 1), (0, 1, 1), (2, 0, 0), (0, 2, 0), (0, 0, 2).