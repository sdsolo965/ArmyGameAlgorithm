Luke is daydreaming in Math class. He has a sheet of graph paper with  rows and  columns, 
and he imagines that there is an army base in each cell for a total of  bases. 
He wants to drop supplies at strategic points on the sheet, marking each drop point with a red dot. 
If a base contains at least one package inside or on top of its border fence, 
then it's considered to be supplied. For example:

Given n and m, what's the minimum number of packages that Luke must drop to supply all of his bases?
Input Format
Two space-separated integers describing the respective values of n and m.
Constraints

Output Format
Print a single integer denoting the minimum number of supply packages Luke must drop.
Sample Input 0
2 2
Sample Output 0
1
Explanation 0
Luke has four bases in a  grid. If he drops a single package where the walls of all four bases intersect, then those four cells can access the package:
image
Because he managed to supply all four bases with a single supply drop, we print 1 as our answer.