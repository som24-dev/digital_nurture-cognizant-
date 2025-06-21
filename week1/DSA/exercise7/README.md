# Exercise 7: Financial Forecasting Using Recursion

## What is Recursion?
Recursion is a technique where a function calls itself to solve smaller instances of the same problem.

## Forecast Formula (used recursively):
FutureValue = InitialValue × (1 + growthRate)^years

## Time Complexity:
- Recursive Version: O(n)
- Optimized with Memoization: O(n), but avoids recomputation

## Why Optimize?
Without memoization, recursive calls repeat the same work, increasing compute time. Memoization stores results of subproblems.

## Example:
- Initial Value: ₹1000
- Growth Rate: 8%
- Years: 5
- Output: ₹1469.33
