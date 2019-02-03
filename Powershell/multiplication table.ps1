Clear-Host
$col=0;
$row=0;
$math=0;
$out = "";

for ($row = 1; $row -le 20; $row++) {

for ($col = 1; $col -le 12; $col++) {

$math = $col *$row;

if ($col -le 11) {

$out += $math.ToString() + "`t`t";


}
else {
$out += $math.ToString() + "`n";
}
}


}

Write-Output $out;
