set terminal svg
set title "Bezier(20,10) = 184756(x^{10})(1-x)^{10}"
set xrange [0:1]
set yrange [0:0.226197]
set xlabel "animation frame"
set ylabel "added velocity"
set xtic 0.1
plot 184756*(x**10)*((1-x)**10) notitle
