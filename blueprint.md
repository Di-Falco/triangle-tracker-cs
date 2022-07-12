take input 3 sides
  convert string input to int

Test if a triangle object is created; are variables created correctly?

check if valid triangle
  check if A+B > C || B+C > A || A+C > B
    >> "Not a triangle"
  
Test: 



Scalene: No sides are equal
  check if A != B && A != C && B != C
    >> "Scalene"

Equilateral: All sides are equal
  check if A == B && A == C && B == C
    >> "Equilateral"

Isosceles: Exactly 2 sides are equal
  else A == B || A == C || B == C 
    >> "Isosceles"