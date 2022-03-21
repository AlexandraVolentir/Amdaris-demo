## Named parameters

It is another way to pass parameters to a method.
It is not mandatory to keep the parameter sequence because we are using named parameters. Regardless of the order of the parameters, the value of the agument
 will be matched based on their names.

## Dynamic in C#
In C# 4.0, a new type is introduced that is known as a dynamic type. It is used to avoid the compile-time type checking.
The compiler does not check the type of the dynamic
type variable at compile time, instead of this, the compiler
gets the type at the run time. The dynamic type variable is
created using dynamic keyword.

With var, the type of the variable is decided by the compiler at compile time.,
whereas with dynamic at runtime. Var variable should be initialized
at the time of delcaration, so that the compiler will decide the
type of the value it initialized. It cannot be used for properties or
returning vaues from the function. It can only be used as a local variable in function.
