# OOP_ClassProject

## Calculator

Programming calculator's functions and a special Paint form to display various geometrical shapes.

Some of interesting parts of the project is:

1. Poland Equation

Create a stack then push all elements of the equation into this stack. When an operator is caught, `stack.pop()` the last 2 numerical elements out.

`if (IsOperator(s))

{
                   
  if(binaryOperatorList.Contains(s))
  
  {
  
    d1 = ReadValue(stack.Pop(), dict);
    
    d2 = ReadValue(stack.Pop(), dict);
    
    result = EvalBinaryOperator(d2, d1, s);
    
    stack.Push(result);
    
  }
  
  if(unaryOperatorList.Contains(s))
  
  {
  
    d1 = ReadValue(stack.Pop(), dict);
    
    result = EvalUnaryOperator(d1, s);
    
    stack.Push(result);
    
  }
  
}

else 
  stack.Push(s);
`
