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
	printf("Hello World!\n");
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

	// combined example
	printf("David says , \" Programming is fun !\"\n");
	printf("**Conditions apply , \"Offers valid until tomorrow\"\n");
	printf("C:\\My computer\\My folder\n");
	printf("D:/My documents/My folder\n");
	printf("\\\\\\\\Today is holiday\\\\\\\\\n");
	printf("this is a triple quoted string\"\"\"This month has 30 days\"\"\"\n");
	return 0;
}