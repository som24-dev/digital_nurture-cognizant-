# Exercise 2: E-commerce Search Function

## Step 1: Asymptotic Notation (Big O)
- Big O notation describes the **upper bound** of an algorithm's time complexity.
- It tells us how an algorithm scales with input size `n`.

### Linear Search
- Best Case: O(1) (if the item is first)
- Average Case: O(n)
- Worst Case: O(n)

### Binary Search
- Best Case: O(1)
- Average/Worst Case: O(log n)
- Requires sorted data.

## Step 4: Analysis
- **Linear Search** is simple and works on unsorted data.
- **Binary Search** is much faster on large datasets, but needs sorting.
- For fast performance on an e-commerce platform, **binary search** or **hash-based structures** are better.
