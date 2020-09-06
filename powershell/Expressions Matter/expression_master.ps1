# https://www.codewars.com/kata/5ae62fcf252e66d44d00008e/train/powershell

function ExpressionMatter([int] $a, [int] $b, [int] $c) {
    $x = $a * ($b + $c);
    $z = $a * $b * $c;
    $v = $a + $b * $c;
    $d = ($a + $b) * $c;
    $e = $a + $b + $c;
    $arr = [array] ($x, $z, $v, $d, $e);

    $max = 0;
    foreach ($item in $arr) {
        if ($max -le $item) {
            $max = $item;
        }
    }

    return $max;
}

write-host (ExpressionMatter 2 1 2)
write-host (ExpressionMatter 1 1 1)