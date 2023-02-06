/*
 * Notes regarding various data types 
 */
#include <stdio.h>

int main() {

	printf("In life we encounter various types of data.\n");
	printf("We encounter data as numbers: 8, 9, 0... etc\n");
	printf("\t\tcharacters: a, b, c, 4, *, etc...\n");
	printf("\t\tstrings: \'I went to the store today\'\n");

	printf("Integers are either signed (positive or negative) or unsigned.\n");
	printf("Signed integers are represented in different forms of data:\n");
	printf("\tchar:          Memory Size: 1, range: -128 to 127 (ASCII)\n");
	printf("\tshort int:     Memory Size: 2, range: -32,768 to 32,767   AKA short\n");
	printf("\tint:           Memory Size: 4, range: -2,147,483,648 to 2,147,483,647\n");
	printf("\tlong int:      Memory Size: 8, AKA long\n");
	printf("\tlong long int: Memory Size: 8, AKA long long\n");
	printf("Unsigned integers are also represented in different forms, just denoted unsigned.\n");
	printf("eg: unsigned char, unsigned int, unsigned long\n");
	printf("unsigned integers utilize the same amount of memory as signed integers, but utilize different ranges.\n");
	printf("\tunsigned char: Memory Size: 1, range: 0 to 255 (ASCII)\n");
	printf("\tunsigned int:  Memory Size: 2, range: 0 to 65,535\n");

	printf("\n\nAside from chars, shorts and long longs, the C Standard does not fix the storage sizes of data types. It only sets the maximum and minimum.\n");
	printf("The size is decided by the compiler a programmer uses. Refer to your compiler's manual for data type sizes.\n");
	printf("\tshorts are always 2 bytes\n\tchars are always 1 byte\n\tlong long is always 8 bytes.\n");

	return 0;
}