function Past([int] $h, [int] $m, [int] $s) {
    return ($s * 1000 + $m * 60000 + $h * 3600000);
}

Write-Host (Past 0 0 1)
Write-Host (Past 0 1 1)
Write-Host (Past 1 0 1)