# Exercise 1: Ranking and Window Functions

##  Objective:
Use SQL window functions to find the **top 3 most expensive products** in each category using:
- `ROW_NUMBER()`
- `RANK()`
- `DENSE_RANK()`
- `OVER()`
- `PARTITION BY`

---

##  Key Concepts:

### `ROW_NUMBER()`
- Assigns a unique rank to each row within a partition
- Used to extract top 3 products per category

### `RANK()`
- Handles ties by giving the same rank
- Skips numbers after a tie (e.g., 1, 2, 2, 4)

### `DENSE_RANK()`
- Handles ties without skipping ranks (e.g., 1, 2, 2, 3)

---

## 🛠 Partitioning Logic:
```sql
OVER (PARTITION BY Category ORDER BY Price DESC)
