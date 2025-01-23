# Unexpected Behavior with Reference Types in C#

This example demonstrates a common pitfall in C# when dealing with reference types.  Many developers unfamiliar with the nuances of C#'s memory management encounter unexpected behavior when modifying objects through references.

The `bug.cs` file shows code where modifying a reference variable unexpectedly modifies the original object.  The `bugSolution.cs` demonstrates how to correctly handle such situations using cloning or creating new instances to avoid unintended side effects.