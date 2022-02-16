/*
The open close principle means
- "open for extension" - behavior of the module can be extended,
  we can make the module behave in new and different ways as the
  requirements of the application change over time.
- "closed for modification" - means that the source code of such a module
is inviolate. No one is allowed to make source code changes to it.

Usually the OCP cannot be fully achieved, but even partial OCP implementation
can bring dramatic improvements in the structure of the application.

So, it is always better if changes do not propagate into existing code that
already works.
*/
