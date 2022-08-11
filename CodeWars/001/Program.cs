
string Derive (double coefficient, double exponent)
  
  {
    double sum = coefficient * exponent;
    double EXP = exponent - 1;

    string result = sum.ToString("x^") ;
    string result1 = EXP.ToString ;
    string FinalResult = result + result1;

    return FinalResult;
  }


string derive = Derive (2,5);
System.Console.WriteLine(derive);