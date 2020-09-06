function Get-CenturyFromYear ([int]$year) {
    $result = $year / 100;
    if ($year % 100 -eq 0) {
        $result += 0;
    }
    else {
        $result += 1;
    }
    return [Math]::Truncate($result);
}

Write-Host (Get-CenturyFromYear 1705)
Write-Host (Get-CenturyFromYear 1900)
Write-Host (Get-CenturyFromYear 1601)