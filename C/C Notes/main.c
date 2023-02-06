#include <stdio.h>

int main() {
	printf("Hello World!");
	// \n - new line
	printf("\nHello\nWorld!\n");
	// \' - single quote
	printf("\'Hello World!\'\n");
	// \" - double quote
	printf("\"Hello world!\"\n");
	// \\ - backslash
	printf("Hello\\World!\n");
	// \a - Bell
	printf("Hello World!\a\n");
	// \b - backspace
	printf("Hello \bWorld!\n");
	// \f form feed
	printf("Hello World!");
	/* \r - return carriage
		moves the cursor to the beginning of the current line horizontally
		will print like so: 
		0 1 2 3 4 5 
		H e l l o		- cursor moves back to index 0 and prints remainder of string from there
		W o r l d !
		output: World!
	 */
	printf("Hello \r world!");
	// \t - horizontal tab 4 spaces
	printf("Hello \t world!");
	// \v - vertical tab
	printf("Hello \v World!");
	return 0;
}