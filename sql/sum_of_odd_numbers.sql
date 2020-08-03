SELECT n*n*n
AS res
FROM nums;

-- Another aproach
SELECT POWER(n, 3)::int as res from nums;