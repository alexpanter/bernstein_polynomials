
n=$1
k=$2
binomial="$(mono bezier.exe $n $k)"
max_y="$(mono max_y_value.exe $n $k $binomial)"
pwr=`expr $n - $k`
title="Bezier($n,$k) = $binomial(x^{$k})(1-x)^{$pwr}"

file=binomial.gp
mkdir bezier_plots
target_html="$(mktemp bezier_plots/bezier_XXXX.html)"

echo "set terminal svg" > $file
echo "set title \"$title\"" >> $file
echo "set xrange [0:1]" >> $file
echo "set yrange [0:$max_y]" >> $file
echo "set xlabel \"animation frame\"" >> $file
echo "set ylabel \"added velocity\"" >> $file
echo "set xtic 0.1" >> $file
echo "plot $binomial*(x**$k)*((1-x)**$pwr) notitle" >> $file

gnuplot $file > $target_html
firefox $target_html

