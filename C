#include <stdio.h>

int main(){
/* print with 3 tabs for centering text and
 3 new lines for spacing between title and table*/
 
printf("\t\t\t    Multiplication Table\n\n\n");

for (int i = 1; i < 11; i++){ /*outside loop 1 to 10*/
	for (int x = 1; x < 11; x++){ /*inside loop 1 to 10 */
		int result = i * x;  /*Multiply outide loop with inside loop */
		printf("%2d\t", result); /*print the result with tab spacing*/
}
	printf("\n"); /* print a new line character for the outside loop*/
}
return 0;
}
