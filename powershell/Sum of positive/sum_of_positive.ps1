function Get-SumOfPositive($NumberArray) {
    $sum = 0;

    $NumberArray | ForEach-Object {
        if ([int]$_ -gt 0) {
            $sum += $_ 
        }
    }

    return $sum;
}

Write-Host (Get-SumOfPositive 1, 2, 3, 4, 5)
Write-Host (Get-SumOfPositive 1, -2, 3, 4, 5)
Write-Host (Get-SumOfPositive -1, 2, 3, 4, -5)
Write-Host (Get-SumOfPositive -1, -2, -3, -4, -5)