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
	// \r - return carriage (essentially deletes anything before \r and returns everything after
	printf("Hello \r world!");
	// \t - horizontal tab 4 spaces
	printf("Hello \t world!");
	// \v - vertical tab
	printf("Hello \v World!");
	return 0;
}