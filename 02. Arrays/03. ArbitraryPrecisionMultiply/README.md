## 3. Multiply two arbitrary-precision integers

Certain applications require arbitrary precision arithmetic. One way to achieve this is to use arrays to represent integers, e.g., with one digit per array entry, with the most significant digit appearing first, and a negative leading digit denoting a negative integer. For example, (1,9,3,7,0,7,7,2,1) represents 193707721 and (-7,6,1,8,3,8,2,5,7,2,8,7) represents -761838257287.

Write a program that takes two arrays representing integers, and returns an integer representing their product. For example, since 193707721 * -761838257287 = -147573952589676412927, if the inputs are (1,9,3,7,0,7,7,2,1} and (-7,6,1,8,3,8,2,5,7,2,8,7), your function should return (-1,4,7,5,7,3,9,5,2,5,8,9,6,7,6,4,1,2,9,2,7).

>Hint: Use arrays to simulate the grade-school multiplication algorithm.