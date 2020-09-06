function IsDivisible([int] $n, [int] $x, [int] $y) {
    return $n % $x -eq 0 -and $n % $y -eq 0
}
  
Write-Host (IsDivisible 3 3 4)
Write-Host (IsDivisible 12 3 4)
Write-Host (IsDivisible 8 3 4)
Write-Host (IsDivisible 48 3 4)