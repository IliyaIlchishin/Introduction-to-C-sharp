
int NumOfDigits (int Binary) 

{
    int digits = 0; 
    if (Binary <10) digits = 1;
    if (Binary >9) digits = 2; 
    if (Binary >99) digits = 3; 
    if (Binary >999) digits = 4; 
    if (Binary >9999) digits = 5; 
    if (Binary >99999) digits = 6; 
    if (Binary >999999) digits = 7; 
    if (Binary >9999999) digits = 8; 
    if (Binary >99999999) digits = 9; 
    if (Binary >999999999) digits = 10; 

    return digits;
}

int digit = NumOfDigits (1);
System.Console.WriteLine(digit);

